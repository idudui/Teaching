##���س����
library(plyr)
library(TTR)
library(quantmod)
library(ggplot2)
library(scales)
library(zoo)
library(xts)
##��������
download<-function(stock,from="2010-01-01"){
  df<-getSymbols(stock,from=from,env=environment(),auto.assign = FALSE)##��������
  names(df)<-c("Open","High","Low","Close","Volume","Adjusted")
  write.zoo(df,file = paste(stock,".csv",sep=""),sep=",",quote=FALSE)##��������
  
}
##���ض�����
read<-function(stock){
  as.xts(read.zoo(file = paste(stock,".csv",sep=""),header=TRUE,sep=",",format="%Y-%m-%d"))
}
stock<-"IBM"
download(stock,from = '2010- 01-01')
IBM<-read(stock)
IBM=as.matrix(IBM)##���������͸ĳɾ���
head(IBM)##�鿴ǰ6������
#chartSeries(IBM)##����ͼ
#chartSeries(IBM,TA="addVo();addSMA();addEnvelope();addMACD();addROC()")##��ָ��ĸ��ӵ�����ͼ
##�����
r=nrow(IBM)##r��������
JunXian<-function(n)#n����
{
  b=matrix(nrow=r,ncol = n)#����һ�����飬��������䶯��������
  close=IBM[,4]
  for(i in 1:n)
  {
    b[,i]=append(close[1:(r-i+1)],rep(0,(i-1)),after = 0)
  }
  jieguo=append(apply(b, 1, mean)[n:r],rep(0,(n-1)),after =0)#ȡ��ֵ���֣�����û�õ����ݱ�0
  jieguo
}
jx5=JunXian(5)##���5����
jx20=JunXian(20)##���20����
IBM=cbind(IBM,jx5)
IBM=cbind(IBM,jx20)##�����ݺϲ�
buy1=NULL##���1
sale1=NULL##����1
buy2=NULL##���2
sale2=NULL##����2
xianjin1=NULL##�ֽ�1
xianjin2=NULL##�ֽ�2
for(i in 1:r){
  ##1�����߽��ײ���
  if(i<20){##ǰ20����ʼ��
    buy1=append(buy1,0)
    sale1=append(sale1,0)
    xianjin1=append(xianjin1,100000)
  }else{
    if(IBM[i-1,4]>IBM[i-1,8]&&IBM[i,4]<=IBM[i,8]){##���
      buy1=append(buy1,1)
      sale1=append(sale1,0)
      xianjin1=append(xianjin1,xianjin1[i-1]-IBM[i,4])
    }else{
      if(IBM[i-1,4]<IBM[i-1,8]&&IBM[i,4]>=IBM[i,8]){##����
        buy1=append(buy1,0)
        sale1=append(sale1,-1)
        xianjin1=append(xianjin1,xianjin1[i-1]+IBM[i,4])
      }else{##����������
        buy1=append(buy1,0)
        sale1=append(sale1,0)
        xianjin1=append(xianjin1,xianjin1[i-1])
      }
    }
  }
  
  ##2�����߽��ײ���
  if(i<20){##ǰ20����ʼ��
    buy2=append(buy2,0)
    sale2=append(sale2,0)
    xianjin2=append(xianjin2,100000)
  }else{
    if(IBM[i-1,7]>IBM[i-1,8]&&IBM[i,7]<=IBM[i,8]){##���
      buy2=append(buy2,1)
      sale2=append(sale2,0)
      xianjin2=append(xianjin2,xianjin2[i-1]-IBM[i,4])
    }else{
      if(IBM[i-1,7]<IBM[i-1,8]&&IBM[i,7]>=IBM[i,8]){##����
        buy2=append(buy2,0)
        sale2=append(sale2,-1)
        xianjin2=append(xianjin2,xianjin2[i-1]+IBM[i,4])
      }else{##��������
        buy2=append(buy2,0)
        sale2=append(sale2,0)
        xianjin2=append(xianjin2,xianjin2[i-1])
      }
    }
  }

}
  
IBM=cbind(IBM,buy1,sale1,buy2,sale2,xianjin1,xianjin2)##�ϲ���������
write.csv(IBM,"C:\\Users\\Administrator\\Desktop\\1.csv")