

#R语言综合案例分析

#案例一：	调查某地区120人的月收入情况。
#其中有6 (3)个变量:性别(分类变量sex:取值为男、女两种)，
#教育程度(分类变量edu:有低、中、高三种)以及月收入(取值
#为定量变量income等。表10.2共有120个观测单位(问卷回答)。
#可以看出这些变量有定性(属性)变量，也有定量(数值)变量。

#读取文件
dat=read.table("E:/income.txt",header=T);dat 
attach(dat)  # 可直接访问dat中属性

#一维列联表分析
table(sex)  #性别联列表
table(edu)  #教育联列表
table(income)   #收入联列表

#作图分析
par(mfrow=c(1,2));barplot(table(sex));barplot(table(edu));par(mfrow=c(1,1)) #条形图

#二维列联表分析
table(sex,edu)  #性别，教育联列表

#作图分析
barplot(table(sex,edu),legend = c("男","女"))   #重叠条形图
barplot(table(sex,edu),legend = c("男","女"),beside=T)   #并列条形图
freq=hist(income) #绘制直方图，获得频数

cbind(m=freq$mids,f=freq$count)  #合并freq$mids和freq$count
stem(income)  #茎叶图
qqnorm(income)  #正态分布图
qqline(income)  #正态回归线

summary(income)  #基本统计量

#定性与定量变量相结合的统计分析
by(income,sex,mean)  #按性别sex分类 计算 收入income的 均值mean
by(income,sex,sd)  #按性别sex分类 计算 收入income的 标准差sd
by(income,sex,summary)  #按性别sex分类 计算 收入income的 基本统计量summary
boxplot(income~sex,north=T) #按性别分类箱线图  （north=F为长方形）

by(income,list(sex,edu),summary)  #按性别和教育程度分类计算收入的基本统计量
boxplot(income~sex+edu,notch=T)  #箱线图

#卡方检验
result=table(sex,edu);result #sex,edu 做表
chisq.test(result)  #卡方检验

#t检验
var.test(income[sex=="男"],income[sex=="女"]) #方差齐性-t检验
t.test(income[sex=="男"],income[sex=="女"])  #t检验

#方差分析
bartlett.test(income~edu)  #方差齐性检验
oneway.test(income~edu)  #方差分析



# 案例二：
#某种水泥在凝固时放出的热量Y(卡/克)与水泥中四种化学成分x1,
#x2，x3，x4有关，现测得13组数据，如表所示.希望从中选出主要
#的变量，建立y关于它们的线性回归方程。

#导入数据
cement<-data.frame(
  X1=c ( 7, 1, 11, 11, 7, 11, 3, 1, 2, 21, 1, 11, 10),
  X2=c(26, 29, 56, 31, 52, 55, 71, 31, 54, 47, 40, 66, 68),
  X3=c( 6, 15, 8, 8, 6, 9, 17, 22, 18, 4, 23, 9, 8),
  X4=c(60, 52, 20, 47, 33, 22, 6, 44, 22, 26, 34, 12, 12),
  Y =c(78.5, 74.3, 104.3, 87.6, 95.9, 109.2, 102.7, 72.5,93.1,115.9, 83.8, 113.3, 109.4)
)

#分析变量的相关性
pairs(cement)

#构造函数
lm.sol<-lm(Y~X1+X2+X3+X4,data = cement)	
summary(lm.sol)  #分析

#逐步回归 step
lm.step<-step(lm.sol)
summary(lm.step)  #分析提取逐步回归结果

#在R软件中，还有两个函数可以用来作逐步回归.这两个函数是add1()和drop1()下面用drop1()计算
drop1(lm.step)
lm.opt<-lm(Y~X1+X2,data=cement)  #去掉x3，x4
summary(lm.opt)








