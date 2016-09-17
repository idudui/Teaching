
#  加载工具包
library(zoo)
library(xts)
library(quantmod)
library(TTR)

#  设置桌面为工作空间
setwd("C:\\Users\\pc\\Desktop")

#  下载数据
download<-function(stock,from="2010-01-01")
{
  df<-getSymbols(stock,from=from,env=environment(),auto.assign = F)  #下载数据
  colnames(df) <-c("Open","High","Low","Close","Volume","Adjusted")
  write.zoo(df,file = paste(stock,".csv",sep = ""),sep = ",",quote = F)   #保存到本地
}

#  本地数据读取
read<-function(stock)
{
  as.xts(read.zoo(file=paste(stock,".csv",sep=""),header = T,sep=",",format = "%Y-%m-%d"))
}

stock<-"IBM"
download(stock,from="2010-01-01")
IBM<-read(stock)

#  使用quantmod包的chartSeries()函数，我们可以画出可视化效果还不错的蜡烛图
chartSeries(IBM)
#  带指标的蜡烛图 
chartSeries(IBM,TA = "addVo();addSMA();addEnvelope();addMACD();addROC()")



#  均线函数
ma<-function(madata,days,r)
{
  j=matrix(nrow=r,ncol=days)    #构建n列矩阵
  for (i in 1:days)
  {
    j[,i]=append(madata[1:(r-i+1)],c(rep(0,i-1)),after=0)
  }
  ma=append(apply(j,1,mean)[days:r],c(rep(0,days-1)),after=0)
}

#  均线分析函数
maIBM<- function(IBM,days1,days2=NA)
{
  ma1=ma(madata=IBM[,5],days1,r=nrow(IBM))
  if(is.na(days2))
  {
    ma2=IBM[,5]
  }
  else
  {
    ma2=ma(madata=IBM[,5],days2,r=nrow(IBM))
  }
  r=nrow(IBM)
  jr=matrix(nrow=r,ncol=6)      #构建6列矩阵
  jr[is.na(jr)] <- 0            #矩阵赋值均为0
  jr[1:days1,3]=100000          #初始资金10W
  for(i in 21:r)
  {
    jr[i,3]=jr[i-1,3]
    jr[i,4]=jr[i-1,4]
    jr[i,5]=jr[i-1,5]
    if(ma2[i-1]<ma1[i-1]&&ma2[i-2]>=ma1[i-2])
    {
      jr[i,1]=IBM[i,2]     #买入价格
      jr[i,2]=1            #买入标志
      jr[i,4]=jr[i,3]%/%jr[i,1]   #持有股数
      jr[i,3]=jr[i,3]%%jr[i,1]    #当前现金
      jr[i,5]=jr[i,1]*jr[i,4]+jr[i,3]    #股票现值
    }
    if(ma2[i-1]>ma1[i-1]&&ma2[i-2]<=ma1[i-2])
    {
      jr[i,1]=IBM[i,2]     #卖出价格
      jr[i,2]=2            #卖出标志
      jr[i,3]=jr[i,3]+jr[i,1]*jr[i,4]    #当前现金
      jr[i,4]=0            #持有股数
      jr[i,5]=jr[i,3]      #股票现值
    }
  
    jr[i,6]=jr[i,5]-jr[i-1,5]      #diff
  }
  return=jr
}

#  读入数据
IBM=read.csv("C:\\Users\\pc\\Desktop\\IBM.csv")

#  20日单均线
jr1=maIBM(IBM,20)

#  5日，20日双均线
jr2=maIBM(IBM,20,5)

#  制作总表
ttable<-function(jr)
{
  colnames(jr) <-c("价格","标志","当前现金","持有股票数","股票现值","diff")
  w=cbind(IBM[,2:7],jr)
  row.names(w)=IBM[,1]
  return=w
}

w1=ttable(jr1)    #单均线总表
write.csv(w1,"C:\\Users\\pc\\Desktop\\IBM结果1.csv")
w2=ttable(jr2)    #双均线总表
write.csv(w2,"C:\\Users\\pc\\Desktop\\IBM结果2.csv")

#  制作买入卖出表
bstable<-function(jr)
{
  s0=which(jr[,2]==1|jr[,2]==2)
  w0=matrix(nrow=length(s0),ncol=6)    #构建6列矩阵
  w0=jr[s0,]
  row.names(w0)=IBM[s0,1]
  return=w0
}

w01=bstable(jr1)    #单均线BS表
write.csv(w01,"C:\\Users\\pc\\Desktop\\IBM买入卖出结果1.csv")
w02=bstable(jr2)    #双均线BS表
write.csv(w02,"C:\\Users\\pc\\Desktop\\IBM买入卖出结果2.csv")


#  双均线总表中加入均线
ma1=ma(madata=IBM[,5],20,r=nrow(IBM))
ma2=ma(madata=IBM[,5],5,r=nrow(IBM))
jr=maIBM(IBM,20,5)
colnames(jr) <-c("价格","标志","当前现金","持有股票数","股票现值","diff")
w=cbind(IBM[,2:7],ma2,ma1,jr)
row.names(w)=IBM[,1]
write.csv(w,"C:\\Users\\pc\\Desktop\\IBM结果10.csv")










