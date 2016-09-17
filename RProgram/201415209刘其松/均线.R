
#均线函数
nmean=function(x,n,r)  
{
  a=matrix(nrow=r,ncol=n)
  for(i in 1:n)
    a[,i]=append(x[1:(r-i+1)],c(rep(0,i-1)),after=0)
  mean=apply(a,1,mean)
  nmean=append(mean[n:r],c(rep(0,n-1)),after=0)
  nmean 
}

#读取文件
IEM=read.csv("D:/IBM.csv")

#20均线
r=nrow(IEM)
result=matrix(0,nrow=r,ncol=7)
close=IEM[,5]
open=IEM[,2]
result[,1]=nmean(x,20,r)

result[20,6]=100000  #初始现金
for(i in 21:r)
{
  if(open[i-1]<=result[i-1,1]&&open[i]>result[i,1])
  {
    result[i,2]=1  #买入信号
    result[i,3]=open[i] #价格
  }
  if(open[i-1]>result[i-1,1]&&open[i]<=result[i,1])
  {
    result[i,2]=-1  #卖出信号
    result[i,3]=open[i] #价格
  }
  
  
  result[i,6]=result[i-1,6] 
  if(result[i,2]==1)
  {
    result[i,4]=result[i,6]%%result[i,3]   #cash
    result[i,5]=result[i,6]/result[i,3]    #amount
  }
  else if(result[i,2]==-1)
  {
    result[i,4]=result[i-1,5]*result[i,3]+result[i-1,4]#cash
    result[i,5]=0                                     #amount
    result[i,6]=result[i-1,5]*result[i,3]+result[i-1,4]#asset
  }
  else
  {
    result[i,4]=result[i-1,4]#cash
    result[i,5]=result[i-1,5] #amount
  }
  
  #diff
  result[i,7]=result[i,6]-result[i-1,6]
}

time=as.character(IEM[,1])#时间
colnames(result)=c("20均线","value","op","cash","amount","asset","diff")
result=cbind(time,result)#合并


#写入数据
write.csv(result,'G:/结果.csv')





#双均线

#20均线
r=nrow(IEM)
result1=matrix(0,nrow=r,ncol=7)
close=IEM[,5]
open=IEM[,2]
result1[,1]=nmean(x,20,r)
five=nmean(x,5,r)

result1[20,6]=100000  #初始现金
for(i in 21:r)
{
  if(five[i-1]<=result1[i-1,1]&&five[i]>result1[i,1])
  {
    result1[i,2]=1  #买入信号
    result1[i,3]=open[i] #价格
  }
  if(five[i-1]>result1[i-1,1]&&five[i]<=result1[i,1])
  {
    result1[i,2]=-1  #卖出信号
    result1[i,3]=open[i] #价格
  }
  
  
  result1[i,6]=result1[i-1,6] 
  if(result1[i,2]==1)
  {
    result1[i,4]=result1[i,6]%%result1[i,3]   #cash
    result1[i,5]=result1[i,6]/result1[i,3]    #amount
  }
  else if(result1[i,2]==-1)
  {
    result1[i,4]=result1[i-1,5]*result1[i,3]+result1[i-1,4]#cash
    result1[i,5]=0                                     #amount
    result1[i,6]=result1[i-1,5]*result1[i,3]+result1[i-1,4]#asset
  }
  else
  {
    result1[i,4]=result1[i-1,4]#cash
    result1[i,5]=result1[i-1,5] #amount
  }
  
  #diff
  result1[i,7]=result1[i,6]-result1[i-1,6]
}
#时间
time=as.character(IEM[,1])
colnames(result1)=c("20均线","value","op","cash","amount","asset","diff")
result=cbind(time,result1)
#写入数据
write.csv(result1,'G:/结果1.csv')

