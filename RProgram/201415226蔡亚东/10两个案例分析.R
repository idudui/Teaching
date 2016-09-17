####第十章(案例分析)###
###调查数据的综合分析##
##例10.1调查某地区120人的月收入情况。其中有3（6）个变量：性别（分类变量sex:取值为男、女两种）。。。
dat=read.table("income.txt",header = T)#本题读进来的数据是数据框
#当访问单个数据框时需要在中间加上"$"字符
#例
dat$sex
dat[,1]##dat的第一行

attach(dat)##将数据框绑定到当前的工作位置里面
#绑定完之后就可以直接访问了
sex
edu
table(sex)###用一维的列联表分析进行描述统计
table(edu)
###做条形图
#制定图形显示规格par(mfrow=c(1,2))将两个图放在一起
#做条形图
barplot(table(sex))
barplot(table(edu))
##二维列联表
table(sex,edu)
barplot(table(sex,edu),legend=c("男","女"))##legend做图例说明
barplot(table(sex,edu),legend=c("男","女"),beside=T)##将数据并列显示
####绘制直方图
freq=hist(incom)##hist()做直方图用
freq$breaks##区间
freq$mids###组中值
freq$count###频数
cbind(m=freq$mids,f=freq$count)###按行合并数据

stem(income)##做茎叶图
qqnorm(income)；qqline(income)###做正态QQ图
summary(income)##基本统计量

by(income,sex,mean)##按性别分类求收入的均值##sex表示分为几组（当sex的类别为几就分为几组）
by(income,sex,sd)##按性别分类求收入的标准差
by(income,sex,summary)##按性别分类求收入的基本统计量

##箱线图
boxplot(income~sex,notch=T)##按性别分类对income做箱线图，notch=T表示箱线图的中间是凹下去的，notch=F表示箱线图是长方形的
 
###按性别和教育程度分类（计算）收入的基本统计量
by(income,list(sex,edu),summary)##list函数表示把sex和edu整合在一起，即生成对象的函数
boxplot(income~sex+edu,notch=T)##按性别和教育程度分类绘制收入的基本统计图


###卡方检验
result=table(sex,edu)##先做一个两维的列联表
chisq.test(result)###对性别和教育程度之间的关系进行卡方的独立性检验

##t检验
##方差的齐性检验
var.test(income[sex=="男"]，income[sex=="女"])
t.test(income[sex=="男"]，income[sex=="女"])

##方差分析（适用于多数据检验（3个或3个以上））
bartlett.test(income~edu)##方差齐性检验
oneway.test(income~edu)##单因素方差分析

###例6.10某种水泥在凝固时放出的热量Y（卡/克）与水泥中的四种化学成分X1、X2、X3、X4有关，数据如表所示，希望从中选出主要的变量，建立Y关于他们的线性回归方程。

lm.sol<-lm(Y~X1+X2+X3+X4,data=cement)##data=cement表示要读取的数据

###回归方程中应该用尽可能少的自变量来反映尽可能多的假设变量
###方法代表：逐步回归方法
lm.step<-step(lm,sol)###通过不断地剔除变量来反应回归模型
add1(lm.step)##不断进行添加的函数
drop1(lm.step)##不断进行剔除的函数
lm.opt<-lm(Y~X1+X2,data=cement);summary(lm.opt)

##library(要载入的包名)
search()##R语言上自动安装的包
##getAnywhere(加函数名)可以看到函数的编写源代码









