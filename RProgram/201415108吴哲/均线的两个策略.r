##加载程序包
library(plyr)
library(TTR)
library(quantmod)
library(ggplot2)
library(scales)
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
jx5=JunXian(5)##求出5均线
jx20=JunXian(20)##求出20均线
IBM=cbind(IBM,jx5)
IBM=cbind(IBM,jx20)##把数据合并
buy1=NULL##买点1
sale1=NULL##卖点1
buy2=NULL##买点2
sale2=NULL##卖点2
xianjin1=NULL##现金1
xianjin2=NULL##现金2
for(i in 1:r){
  ##1条均线交易策略
  if(i<20){##前20条初始化
    buy1=append(buy1,0)
    sale1=append(sale1,0)
    xianjin1=append(xianjin1,100000)
  }else{
    if(IBM[i-1,4]>IBM[i-1,8]&&IBM[i,4]<=IBM[i,8]){##买点
      buy1=append(buy1,1)
      sale1=append(sale1,0)
      xianjin1=append(xianjin1,xianjin1[i-1]-IBM[i,4])
    }else{
      if(IBM[i-1,4]<IBM[i-1,8]&&IBM[i,4]>=IBM[i,8]){##卖点
        buy1=append(buy1,0)
        sale1=append(sale1,-1)
        xianjin1=append(xianjin1,xianjin1[i-1]+IBM[i,4])
      }else{##不卖不卖点
        buy1=append(buy1,0)
        sale1=append(sale1,0)
        xianjin1=append(xianjin1,xianjin1[i-1])
      }
    }
  }
  
  ##2条均线交易策略
  if(i<20){##前20条初始化
    buy2=append(buy2,0)
    sale2=append(sale2,0)
    xianjin2=append(xianjin2,100000)
  }else{
    if(IBM[i-1,7]>IBM[i-1,8]&&IBM[i,7]<=IBM[i,8]){##买点
      buy2=append(buy2,1)
      sale2=append(sale2,0)
      xianjin2=append(xianjin2,xianjin2[i-1]-IBM[i,4])
    }else{
      if(IBM[i-1,7]<IBM[i-1,8]&&IBM[i,7]>=IBM[i,8]){##卖点
        buy2=append(buy2,0)
        sale2=append(sale2,-1)
        xianjin2=append(xianjin2,xianjin2[i-1]+IBM[i,4])
      }else{##不买不卖点
        buy2=append(buy2,0)
        sale2=append(sale2,0)
        xianjin2=append(xianjin2,xianjin2[i-1])
      }
    }
  }

}
  
IBM=cbind(IBM,buy1,sale1,buy2,sale2,xianjin1,xianjin2)##合并各个数据
write.csv(IBM,"C:\\Users\\Administrator\\Desktop\\1.csv")