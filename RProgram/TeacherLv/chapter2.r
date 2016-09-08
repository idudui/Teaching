#第二章R软件的使用
#2.1R软件简介 


#2.1.2 初识R软件-三个例子
#例2.1
# 输入体重
X1<-c(35, 40, 40, 42, 37, 45, 43, 37, 44, 42, 41, 39)
# 计算体重的均值和标准差
mu1<-mean(X1); sigma1<-sd(X1) 
# 输入胸围
X2<-c(60, 74, 64, 71, 72, 68, 78, 66, 70, 65, 73, 75)
# 计算胸围的均值和标准差
mu2<-mean(X2); sigma2<-sd(X2)

#例2.2 
hist(X1) # 绘出体重的直方图
plot(X1,X2)#绘制二者关系的散点图

#例2.3 
#设置工作路径
setwd('D:\\1 教学相关2016-2017-1\\1 教学相关-2016-2017（1）\\CSharpStudy\\RProgram\\TeacherLv')
rt<-read.table("exam0203.txt", head=TRUE); rt
#做线性回归
lm.sol<-lm(Weight~Height, data=rt)
summary(lm.sol)


#2.2数字 字符与向量
#2.2.1 向量

#补充知识
#数据对象及类型
#R语言创建和控制的 实体对象被称为对象（object），
#它们可以是变量、数组、字符串、函数或者其它通过这些实体定义的更一般的结构（structures）。
#在R语言中，对象是通过名字创建和保存的。
#在R命令行（控制台）（console）窗口里可以用ls（）命令来查看当前系统里的数据对象。
#character（0）表示没有数据对象
ls()

#1.向量的赋值
x=c(10.4 , 5.6 , 3.1)
x<-c(10.4 , 5.6 , 3.1)
assign("x",c(10.4,5.6,3.1))

c(10.4,5.6,3.1)->x
y<-c(x,0,x)

#2.向量的运算
x=c(-1,0,2)
y=c(3,8,2)
v=2*x+y+1;v
v=y+1;v

x*y
x/y
x^2
y^x

#整数除法
5%/%3
#求余数
5%%3
exp(x)
#sqrt(x)#有警告，负数开方应该写成如下复数形式
sqrt(-2+0i)



#3.与向量运算有关的函数
#(1)求向量的最小值 最大值 和范围的函数
#min max range---x的范围
x=c(10,6,4,7,8)
min(x)
max(x)
range(x)

#重点which
which.min(x)
which.max(x)

#(2) 求和 求乘积
sum(x)
prod(x)#求乘积
length(x)


#2.2.2 产生有规律的序列
#1 等差序列
1:10
2.312:6
4:7.6
x=-2*1:15;x
n=5;

#这两个是不一样的，易错点：等比序列优先级最高
1:n-1
1:(n-1)



#2 等间隔函数
#形式1
s1=seq(-5,5,by=0.2);s1
#形式2
s2=seq(length=51,from=-5,by=0.2);s2


#3 重复函数
x=c(1,4,6.25);x
s= rep(x,times=3);s





#2.2.3逻辑向量
x=1:7;x
l=x>3;l #得到的l不是单个的逻辑值，而是一个向量

x2=4:10;x2
m=x2>8;m

#逻辑运算符  & |
l
m
n=l&m;n

#逻辑变量赋值，注意大小写，注意智能提示，F和T是对应的缩写，不能用小写
z=c(TRUE,FALSE,F,T)

#all全都是   any-有
all(c(1,2,3,4,5,6,7)>3)
any(c(1,2,3,4,5,6,7)>3)


#2.2.4缺失数据
#NA表示数据缺失
z=c(1:3,NA);z
#is.na()检测是否缺失数据
ind=is.na(z);ind
#给缺失值赋值
z
z[is.na(z)]=0;z   #[]表示对向量的位置操作

#is.nan不确定；is.finite有限，is.infinite()无穷
x=c(0/1,0/0,1/0,NA);x
is.nan(x)
is.finite(x)
is.infinite(x)
is.na(x) #不确定数据也认为是缺失数据；反过来则不是：缺失数据不是不确定数据；

#2.2.5 字符型向量
y=c("er","sdf","eir","jk","dim");y
#字符串连接paste
paste("abc","def")
labs1=paste("x",1:6,sep="");labs1
labs2=paste("result.",1:4,sep="");labs2
labs3=paste(1:10);labs3 #等同于命令as.character(1:10)
labs4=paste("Today is",date());labs4
labs5=paste(c('a','b'),collapse='.');labs5 













































































