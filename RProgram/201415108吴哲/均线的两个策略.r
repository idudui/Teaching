##���س����
library(TTR)
library(quantmod)
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
l=0##�������õ�������
k=0
celue<-function(day1,day2,n){##�����������
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
  colnames(leibiao)=c("���","����","�ֹ���","��ǰ�ֽ�")
  jx20=JunXian(day2)
  IBM=cbind(IBM,jx20)##�����ݺϲ�
  for(i in 1:r){
    if(i<22){#����ֵ
      leibiao[i,4]=100000
    }else{
      leibiao[i,3]=leibiao[i-1,3]##����ֵ
      leibiao[i,4]=leibiao[i-1,4]##����ֵ
      if(IBM[i-2,l]>=IBM[i-2,k]&&IBM[i-1,l]<IBM[i-1,k]){##���
        leibiao[i,1]=1##���ź�
        leibiao[i,3]=leibiao[i-1,4]%/%IBM[i,4]##���Ʊ��
        leibiao[i,4]=leibiao[i-1,4]-IBM[i,4]*leibiao[i,3]##�����ֽ�
      }
      if(IBM[i-2,l]<=IBM[i-2,k]&&IBM[i-1,l]>IBM[i-1,k]){##����
        if(leibiao[i-1,3]>0){
          leibiao[i,2]=-1##���ź�
          leibiao[i,3]=0##�����Ʊ
          leibiao[i,4]=leibiao[i-1,4]+IBM[i,4]*leibiao[i-1,3]##�����ֽ�
          }
        }
        }
    }
    if(i==r){##���ʱ��ƽ��
      leibiao[i,1]=0
      leibiao[i,2]=0
      leibiao[i,4]=leibiao[i-1,4]+leibiao[i-1,3]*IBM[i,4]##ƽ���ֽ�
      leibiao[i,3]=0
    }
    leibiao
  }
##һ�����߲���
cl1=celue(day1=5,day2=20,n=1)
##�������߲���
cl2=celue(day1=5,day2=20,n=2)
IBM=cbind(IBM,cl1,cl2)
write.csv(IBM,"C:\\Users\\Administrator\\Desktop\\1.csv")