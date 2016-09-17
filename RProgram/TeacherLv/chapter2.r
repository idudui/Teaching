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
labs1=paste("x",1:6,sep=".");labs1
labs2=paste("result.",1:4,sep="");labs2
labs3=paste(1:10);labs3 #等同于命令as.character(1:10)
labs4=paste("Today is",date());labs4
labs5=paste(c('a','b'),collapse='.');labs5 
?paste

paste(1:10)  #same as as.character(1:10)
y<-paste(1:10,collapse='s');y

x1<-paste(1,2,3,4,5,collapse='s');x1
x1<-paste("a","b",collapse='s');x1
x2<-paste("1","2","3","4","5",collapse='s');x2


#2.2.6 复数向量
x=sqrt(-2+0i);x

x <- seq(-pi, pi, by=pi/10)
y <- sin(x)
z <- complex(re=x, im=y) #产生复数complex
plot(z)
lines(z)


#2.2.7 向量下标运算
#下标取值
x <- c(1,4,7)
x[2]
(c(1, 3, 5) + 5)[2]
#下标赋值
x[2] <- 125 #单独改变一个元素的值
x
x[c(1,3)] <- c(144, 169)
x


# 1、逻辑向量
x <- c(1,4,7)
x
x < 5 #结果是一个向量
x[x<5]
z <- c(-1, 1:3, NA);z
z[is.na(z)] <- 0;z #赋值
z <- c(-1, 1:3, NA);z
y <- z[!is.na(z)]  #将向量中非缺失数据赋给另一个向量
y
(z+1)[(!is.na(z)) & z>0] -> x
x

#改变部分元素值的技术与逻辑值下标结合可以定义分段函数
y <- numeric(length(x)) #numeric产生数值型向量
y[x<0] <- 1 - x[x<0]
y[x>=0] <- 1 + x[x>=0]
y




#2、下标的正整数运算
v <- 10:20;v
v[c(1,3,5,9)]
v[1:5]
v[c(1,2,3,2,1)]
c("a","b","c")[rep(c(2,1,3), times=3)]





#3、下标的负整数运算--表示扣除相应的元素
v[-(1:5)] 


#4、取字符型值的下标向量
ages <- c(Li=33, Zhang=29, Liu=18)
ages
ages["Zhang"]

#向量元素名可以后加
fruit <- c(5, 10, 1, 20)
names(fruit) <- c("orange", "banana", "apple", "peach")
fruit





#2.3 对象和它的模式和属性
#2.3.1 R对象都有两个固有属性：mode和length
mode(c(1,3,5)>5)

#检验对象属性
z <- 0:9
is.numeric(z)
is.character(z)
length(2:4)
length(z)

#类型转换
digits <- as.character(z); digits
d <- as.numeric(digits); d

#2.3.2 修改对象的长度
x <- numeric(0);x  #长度为0
x[3] <- 17
x

#增加对象长度
x <- 1:3
x <- 1:4     

#减少对象长度
x <- x[1:2]  
x
alpha <- 1:10
alpha <- alpha[2 * 1:5]
alpha


#2.3.3 attributes() 和 attr()函数--返回特殊属性
x <- c(apple=2.5,orange=2.1); x
attributes(x) #查看属性

#存取对象object的名为names的属性
attr(x,"names")
attr(x,"names") <- c("apple","grapes"); x #改变属性值
attr(x,"type") <- "fruit"; x #定义新属性

#查看所有特殊属性
attributes(x)


#2.3.4 对象的class属性





#2.4 因子
#2.4.1 factor() 函数
sex <- c("M","F","M","M", "F")
sexf <- factor(sex); sexf
?factor

#获取因子水平
sex.level <- levels(sexf); sex.level
#统计各类数据的频数
sex.tab <- table(sexf); sex.tab

#2.4.2 tapply()函数：分组计算
height <- c(174, 165, 180, 171, 160)
#分组计算
tapply(height, sex, mean)

#2.4.3 gl(函数) ：产生因子
?gl
gl(3,5)
gl(3,1,15)


#2.5 多维数组和矩阵
#2.5.1 生成数组或矩阵
#1 将向量定义成数组
z<-1:12;z
dim(z)<-c(3,4)
z
#再把向量定义为一维数组
dim(z)<-12
z

#2 用array()函数构造多维数组
X <- array(1:20,dim=c(4,5))
X
X <- array(z,dim=c(4,5,2))
X
Z <- array(0,dim=c(3, 4, 2))
Z

#3 用matrix（）函数构造矩阵
A<-matrix(1:15, nrow=3,ncol=5,byrow=TRUE)
A=matrix(1:15, nrow=3,ncol=5);A
#下面两种方法效果一样
A<-matrix(1:15, nrow=3,byrow=TRUE);A
A<-matrix(1:15, ncol=5,byrow=TRUE);A




#2.5.2 数组下标
#2.5.2.1 数组下标
a <- 1:24
dim(a) <- c(2,3,4)
a
a[2, 1, 1]
a[2, 1, 2]
a[1, 2:3, 2:3]
a[1, 2:3, 1:4]
a[1, , ]
a[ , 2, ]
a[1,1, ]

#为数组每个元素赋值0
a []<-0 

#用数据向量来取子集
a[3:10]




#2.5.2.2 不规则的数组下标
#先定义一个矩阵
b <- matrix(c(1,1,1,2,2,3,1,3,4,2,1,4), ncol=3, byrow=T)
b
#用定义好的矩阵的元素定义位置，取出对应内容
a[b] #中括号里一定表示的是下标，即元素位置；用矩阵也是表示的位置
#可以给其赋值
a[b] <- c(101,102,103,104)
a



#2.5.3 数组的四则运算
A <- matrix(1:6, nrow=2, byrow=T); A
B <- matrix(1:6, nrow=2); B
C <- matrix(c(1,2,2,3,3,4), nrow=2); C
D <- 2*C+A/B; D

#长短不一样的向量（或数组）进行运算
x1 <- c(100,200)
x2 <- 1:6
x1
x2
x1+x2

x3 <- matrix(1:6, nrow=3);x3
x1
x3
x1+x3

#无法匹配的时候会警告
x1
x2 <- 1:5
x1+x2


#2.5.4 矩阵的运算
















