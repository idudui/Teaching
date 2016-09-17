

###########案例1#################
#读取文件
dat=read.table("E:/1.txt",header=T)

#列联表分析
attach(dat)
table(sex)
table(edu)
#条形图
par(mfrow=c(1,2))
barplot(table(sex))
barplot(table(edu))
par(mfrow=c(1,1))

#二维列联表分析
table(sex,edu)
barplot(table(sex,edu),legend = c("男","女"))
barplot(table(sex,edu),legend = c("男","女"),beside=T)

freq=hist(income)#绘制直方图并获得频数
cbind(m=freq$mids,f=freq$counts)#形成常规频数表
stem(income)#茎叶图
#正态性q-q图
qqnorm(income)
qqline(income)

summary(income)#基本统计量
by(income,sex,mean)#按性别分别求收入均值
by(income,sex,sd)#按性别分别求标准差
by(income,sex,summary)#按性别分别求收入的基本统计量

boxplot(income~sex,north=T)#按性别分类绘制收入的基本统计图
by(income,list(sex,edu),summary)#按性别和教育程度分别求收入的基本统计图
boxplot(income~sex+edu,notch=T)#按性别和教育程度分类绘制收入的基本统计图

#卡方检验
result=table(sex,edu)
chisq.test(result)#卡方检验
var.test(income[sex=="男"],income[sex=="女"])#进行t检验
t.test(income[sex=="男"],income[sex=="女"])#进行t检验

#方差分析
bartlett.test(income~edu)#方差齐性检验
oneway.test(income~edu)



#############案例2#############

#读取数据
cement<-data.frame(
  X1=c( 7, 1, 11, 11, 7, 11, 3, 1, 2, 21, 1, 11, 10),
  X2=c(26, 29, 56, 31, 52, 55, 71, 31, 54, 47, 40, 66, 68),
  X3=c( 6, 15, 8, 8, 6, 9, 17, 22, 18, 4, 23, 9, 8),
  X4=c(60, 52, 20, 47, 33, 22, 6, 44, 22, 26, 34, 12, 12),
  Y =c(78.5, 74.3, 104.3, 87.6, 95.9, 109.2, 102.7, 72.5,93.1,115.9, 83.8, 113.3, 109.4))
  

lm.sol<-lm(Y~X1+X2+X3+X4,data = cement)		#构造函数
summary(lm.sol)#基本统计信息

#用step（）函数作逐步回归
lm.step<-step(lm.sol)
summary(lm.step)


#用trop1（）函数作逐步回归
drop1(lm.step)
lm.opt<-lm(Y~X1+X2,data=cement)
summary(lm.opt)
