##加载程序包
library(TTR)
library(quantmod)
library(zoo)
library(xts)
##下载数据
download<-function(stock,from="2010-01-01"){
  df<-getSymbols(stock,from=from,env=environment(),auto.assign = FALSE)##载入数据
  names(df)<-c("Open","High","Low","Close","Volume","Adjusted")
  write.zoo(df,file = paste(stock,".csv",sep=""),sep=",",quote=FALSE)##保存数据
  
}
##本地读数据
read<-function(stock){
  as.xts(read.zoo(file = paste(stock,".csv",sep=""),header=TRUE,sep=",",format="%Y-%m-%d"))
}
stock<-"IBM"
download(stock,from = '2010- 01-01')
IBM<-read(stock)
IBM=as.matrix(IBM)##把数据类型改成矩阵
head(IBM)##查看前6条数据
#chartSeries(IBM)##蜡烛图
#chartSeries(IBM,TA="addVo();addSMA();addEnvelope();addMACD();addROC()")##带指标的复杂的蜡烛图
##求均线
r=nrow(IBM)##r代表行数
JunXian<-function(n)#n均线
{
  b=matrix(nrow=r,ncol = n)#构建一个数组，挨个储存变动过的数据
  close=IBM[,4]
  for(i in 1:n)
  {
    b[,i]=append(close[1:(r-i+1)],rep(0,(i-1)),after = 0)
  }
  jieguo=append(apply(b, 1, mean)[n:r],rep(0,(n-1)),after =0)#取均值部分，并把没用的数据变0
  jieguo
}
l=0##计算是用到的列数
k=0
celue<-function(day1,day2,n){##构建结果函数
  if(n==1){
    l=4
    k=7
  }else{
    l=7
    k=8
    jx5=JunXian(day1)
    IBM=cbind(IBM,jx5)
  }
  leibiao=matrix(0,nrow = r,ncol = 4)
  colnames(leibiao)=c("买点","卖点","持股数","当前现金")
  jx20=JunXian(day2)
  IBM=cbind(IBM,jx20)##把数据合并
  for(i in 1:r){
    if(i<22){#赋初值
      leibiao[i,4]=100000
    }else{
      leibiao[i,3]=leibiao[i-1,3]##赋初值
      leibiao[i,4]=leibiao[i-1,4]##赋初值
      if(IBM[i-2,l]>=IBM[i-2,k]&&IBM[i-1,l]<IBM[i-1,k]){##买点
        leibiao[i,1]=1##买信号
        leibiao[i,3]=leibiao[i-1,4]%/%IBM[i,4]##买股票数
        leibiao[i,4]=leibiao[i-1,4]-IBM[i,4]*leibiao[i,3]##手中现金
      }
      if(IBM[i-2,l]<=IBM[i-2,k]&&IBM[i-1,l]>IBM[i-1,k]){##卖点
        if(leibiao[i-1,3]>0){
          leibiao[i,2]=-1##卖信号
          leibiao[i,3]=0##卖完股票
          leibiao[i,4]=leibiao[i-1,4]+IBM[i,4]*leibiao[i-1,3]##手中现金
          }
        }
        }
    }
    if(i==r){##最后时刻平仓
      leibiao[i,1]=0
      leibiao[i,2]=0
      leibiao[i,4]=leibiao[i-1,4]+leibiao[i-1,3]*IBM[i,4]##平仓现金
      leibiao[i,3]=0
    }
    leibiao
  }
##一条均线策略
cl1=celue(day1=5,day2=20,n=1)
##两条均线策略
cl2=celue(day1=5,day2=20,n=2)
IBM=cbind(IBM,cl1,cl2)
write.csv(IBM,"C:\\Users\\Administrator\\Desktop\\1.csv")