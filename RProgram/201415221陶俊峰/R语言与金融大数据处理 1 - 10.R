

#########################################################################################

###    02.R基础知识
# 课程内容：变量赋值、分支结构、循环结构、函数使用、获取帮助等知识


## 变量赋值

# 通过赋值生成一个新变量（不需要声明）
x <- 1.5;print(x)   #可用x代替print(x)   可用=赋值
y1 <- c(1.5,2.3,8.6,7.4,9.2);y1  #c()  生成向量
y2 <- c("MSFT","GOOG","AAPL");y2  #字符串向量
y3 <- c(T,F,T,T,F,F);y3  #逻辑向量 R中 True 可简写成T ，False 简写成F
3.1415926 -> z;z   # 通过 <- 赋值 可以不考虑值与变量名的先后

assign("t",1.414);t    # assign()函数给变量赋值，将1.414赋值给t
szSymbolName <- 'GSPC'     # assign()函数的有趣用途：将数值赋值给保存在字符串变量中的变量名
assign(szSymbolName,1860);GSPC

# 可一次输入多个数据
cat("x = ",x,"\n",sep="")

# 显示当前内存中的所有变量、函数名称
ls()

# 删除内存中的指定名称变量
rm(GSPC)

# 删除内存中加载的所有变量和函数，慎用
rm(list=ls())


## 分支结构

a <- 1
if(a==1) print("a==1")  #如果a=1  输出a=1

a <- 2
if(a > 1)  print("a > 1")   else   print("a <= 1")  #如果a大于1输出a > 1，否则输出a <= 1

a <- 3
if( a == 1)
{
  print("a == 1")
}else             # 注意这里，else必须紧跟在上一个}后面
{
  print("a != 1")
}                 #如果a=1输出a == 1 ，否则输出a != 1

# 多重分支结构，同样每个else必须紧跟在上一个}后面
a <- 4
if( a == 1)
{
  print("a == 1")
}else if( a == 2)
{
  print("a == 2")
}else
{
  print("Not 1 & 2")
}          #如果a=1输出a == 1 ，如果a=2输出a == 2，否则输出Not 1 & 2


# ifelse()计算第一个逻辑表达式得到结果如果为T则返回第二个参数；否则返回第三个参数
a <- 2
print( ifelse(a > 1,3.1416,1.414) )
#如果a>1 打印3.1416 否则打印1.414

# switch语句的多重分支结构
n <- 1

switch(n,
       print("选项1"),
       print("选项2"),
       print("选项3"),
       print("选项4"),
       print("选项5")
)      #switch执行相应的第n个函数


## for循环结构

iTotal <-  0
for(i in 1:100)   # 使用关键词in枚举向量中的每一整数 ，i的值从1循环到100
{
  iTotal <- iTotal + i
} 
cat("1-100的累加和为：",iTotal,"\n",sep="")

# 字符串也同样可以成功枚举
szSymbols <- c("MSFT","GOOG","AAPL","INTL","ORCL","SYMC")
for(SymbolName in szSymbols)
{
  cat(SymbolName,"\n",sep="")
}  #依次输出"MSFT","GOOG","AAPL","INTL","ORCL","SYMC"

# while循环
i <- 1
iTotal <- 0
while(i <= 100)   #循环条件i <= 100
{
  iTotal <- iTotal + i
  i <- i + 1
}
cat("1-100的累加和为：",iTotal,"\n",sep="")

# repeat循环
i <- 1
iTotal <- 0
repeat    #无条件循环
{
  iTotal <- iTotal + i
  i <- i + 1
  if(i <= 100) next else break   #须在程序内部设法退出 next下一次 break跳出循环
}
cat("1-100的累加和为：",iTotal,"\n",sep="")


## 自定义函数
# 注意：建立功能丰富、庞大、专业的自定义函数库、类库是公司的核心竞争力
#pt <- function()
{ 
  szCurTime <- as.character.Date(Sys.time()); options(prompt=paste(szCurTime,">",sep=""))
}
pt() #将控制台的标识符改成最新的时间和日期

# 定义自己的二元运算符，%anything%，两个百分号之间可以是任何字符串
# 定义二元运算符的过程和编写自定义函数本质相同
"%g%" <- function(x,y)
{
  print(x+y)
  print(x-y)
  print(x*y)
  print(x/y)
}  
3%g%5


## 获取帮助信息

?print             #在RStudio右侧打开相关帮助界面
help(print)        #与?print相同

example(print)     #示例

?quantmod          #打开扩展包整体帮助信息

apropos("print*")  #在搜索路径下查找满足正则表达式的所有函数信息

demo(graphics)     #示例代码相关函数

#########################################################################################
#心得：
#else必须紧跟在上一个}后面
#定义自己的二元运算符，%anything%，两个百分号之间可以是任何字符串
#repeat循环，无条件循环，须在程序内部设法退出 next下一次 break跳出循环

#########################################################################################


###   03.R常用数据结构
# 课程内容：介绍向量、数组、列表、数据框、日期时间等数据结构的基础知识，以及生成这些结构的方法



## 向量

x <- c(1,2,3,4,5);print(x)  #通过c生成

x <- 1:10;print(x)   #用a:b 生成a~b向量 默认步长1

x <- seq(from=1,to=10);print(x)   # 1~10

x <- seq(from=1,to=10,by=2);print(x)  #1~10 步长为2

x <- seq(from=1,to=10,length.out=50);print(x)  #1~10  50个数据


# 生成日期变量并用生成的日期变量生成一组日期序列数据
s <- as.Date("2014-1-1")  #as.Date()转化为日期变量
e <- as.Date("2014-4-1")
dtVec <- seq(from=s,to=e,by=1)   #以一天为的步长向量
print(dtVec)
print(class(dtVec))   #class()查看类型


# 生成一组重复数据。使用常数初始化指定长度的向量
x <- rep(1,10);print(x)   #生成重复向量， 10个

x <- rep("USD",5);print(x)  #字符串也可以

# sample()取样函数从一组数据中随机取出指定数量的数据
# replace参数决定是否可以重复取数
y <- sample(x=1:100,size=10,replace=F);print(y)  #从1:100 取十个，不重复

y <- sample(x=c(0,1),size=20,replace=T);print(y)  #从c(0,1) 取20个，可重复

# 使用正态分布随机数生成函数生成指定数量、平均值、标准差的随机数
x <- rnorm(n=10,mean=100,sd=20);print(x)  #rnorm生成正态分布 10个均值100标准差20的数


## 数组

# 生成向量然后通过设置行列数据转换成二维数组
x <- 1:20
dim(x) <- c(5,4)  #把x生成5行4列数组
print(x)

# 直接生成数组并初始化每个元素为3.14
x <- array(3.14,dim=c(5,4))   #3.14固定值
print(x)


# 可以生成三维数组
# 使用正态分布随机数初始化整个数组
x <- array(rnorm(40,10,5),dim=c(5,4,2))   #rnorm(40,10,5)正态分布随机数
print(x)
print(length(x))  # 对于矩阵length()函数得到的是所有元素的总数量（向量为长度）


## 数据框
# 数据框的形式和Excel比较相似
# 每一列可以看做是一个向量，类型相同；不同列数据之间可以有不同类型
# 同列表的重要区别是：数据框要求每一列数据长度相同
# 数据框的每一行可以看作是一条记录，每一列看做是记录的某一个属性
# 数据框是金融大数据处理中非常重要的数据结构，用途很广必须深入了解
df  <- data.frame(symbols=c("MSFT","KO","CSCO"),price=c(40.40,40.56,23.02),currency=rep("USD",3),country=rep("USA",3),type=rep("STOCK",3))
df   #每一列都是一个向量
print(class(df))

#nrow()返回行数 ncol()返回列数
cat("df数据框行数为：",nrow(df),"\ndf数据框列数为：",ncol(df),"\n",sep="")
#length()返回列数（属性）数量
cat("df数据框总元素数量为：",length(df),"\n",sep="") 

## 列表
# 列表使用list()函数来定义，列表中的每个元素可以是单个变量或者是向量，甚至是另一个列表
# 列表中每个向量的长度可以不同，这是列表和数据框的重要区别
# 数据框是一种形式特殊的列表
lst <- list(symbols=c("MSFT","KO","CSCO"),price=c(40.40,40.56,23.02),currency="USD",country="USA",type="STOCK" )
lst
print(length(lst))  # 共5个元素



## 日期类变量
dtVar <- Sys.Date()   #返回当前日期
print(class(dtVar));print(dtVar)

dtVar <- Sys.time()   #返回当前时间和日期
print(class(dtVar));print(dtVar)

dtVar <- as.Date("2014-4-17",tz="UTC")   #tz 设置时区
print(class(dtVar));print(dtVar)

dtVar <- as.Date("2014/4/17",tz="CST")   # '-' 和'/' 均可
print(class(dtVar));print(dtVar)


# 用数字直接生成日期对象
# ISOdate()函数得到的是一个POSIXct对象
t <- ISOdate(2014,4,17)   #默认午夜时间
print(class(t));print(t)

# 允许继续加入小时、分钟、秒数信息
t <- ISOdatetime(2014,4,17,15,28,48)
print(class(t));print(t)

# 将Date日期转换成儒略日期
# 在R中这是自1970-1-1以来的天数
d <- as.Date("2014-4-17")
as.integer(d)  #转换为整数
julian(d)   #儒略日期

# 提取日期中的各个组成部分信息
d <- Sys.time()
p <- as.POSIXlt(d)    #将时间转换为POSIXlt格式 方便提取
print(class(p));print(mode(p));print(p)

print(p$year+1900)   # p$year 自1900年以来的年份
print(p$mon+1)       # p$mon  表示0-11月
print(p$mday)        # p$mday 该月的第几天

print(p$yday+1)      # p$yday 该年的第几天，0-365天，元旦当天是第0天
print(p$wday)        # p$wday 对应周几，0-6，周日为0，其他时间和我们日常习惯一致


#########################################################################################
#心得：
# length.out  x <- seq(from=1,to=10,length.out=50);print(x)  #1~10  50个数据
# 日期类变量
# 提取日期中的各个组成部分信息

#########################################################################################

###   04.R的数据操作
# 课程内容：R提供了极其灵活的方式，访问、修改、扩充、删除、计算向量、列表、数据框等基础数据结构

## 访问向量中元素

x <- 1:10;x

x[5]    #[] 中填入索引

x[-5]   #- 指排除这个索引

x[c(1,5,8)]   #[]可以是个向量

x[1:5]

x[1:5*2]    #冒号优先级更高，首先得到1-5这5个数据再乘以2，2,4,6,8,10

x[ x > 5 ]     #逻辑表达式用x中每一个元素计算逻辑表达式的值做索引，得到的是原数组中x大于5的元素

mean(x)     #均值
x[x > mean(x)]    # 逻辑表达中可以使用函数，所有大于平均值的

names(x) <- LETTERS[1:10];x   # 使用字符常数数组给向量命名，再通过变量名访问向量中的元素
#LETTERS[1:10] 用1:10 字幕A~J 为向量命名
x["A"]        #可用名字索引

View(x)   #查看


# 计算向量的长度
length(x)

# 修改指定位置的向量元素
x <- 1:10;x
x[5] <- 100;x   #直接修改第5个

# 追加向量元素增加向量长度
x <- 1:10;x
x <- c(x,11,12,13);x    #实质是用c(x,11,12,13)覆盖x

# 直接在向量末尾写入数据
x <- 1:10;x
x[length(x)+1] <- 11;x  #直接在长度后加一，并赋值


# 在向量指定位置插入数据
# 并不是在原来的向量中插入数据而是返回一个新的向量
# after参数表示在原向量中的那个向量后面插入数据
x <- 1:10;x
y <- append(x,11:13,after=0);x;y  #append 在x中第0（after=0）个元素后加入11:13
y <- append(x,11:13,after=5);x;y  #append 在x中第5（after=5）个元素后加入11:13



## 访问列表
lst <- list(symbols=c("MSFT","KO","CSCO"),price=c(40.40,40.56,23.02),currency="USD",country="USA",type="STOCK" )
lst[1]         #[1]为第一元素，即symbols=c("MSFT","KO","CSCO")
lst$symbols    #也可以用列名直接访问

lst[[1]]      # 该列表的第一个元素是一个向量symbols，
lst$symbols[1]  # 该列表中symbols向量的第一个元素


# 在列表末尾添加一个新的元素TradeDate
names(lst)   #查看列表名
lst$TradeDate <- as.Date(rep("2014-4-17",3))  #直接增加属性名用$，直接赋值
names(lst)


# 在列表任意位置添加一个新的元素
z <- list(plantform = rep("FXCM",3))
lst <- append(lst,z,after=0)  #append 在lst中第0（after=0）个元素后加入z
names(lst)
str(lst)  #查看列表属性内容


# 删除列表中的指定项
names(lst)
lst$price <- NULL   #通过用NULL覆盖删除
names(lst)



## 矩阵访问

data(EuStockMarkets)

print(head(EuStockMarkets))  #head 查看头数据 默认6行
print(class(EuStockMarkets))  #class 查看类型
print(summary(EuStockMarkets))  # 查看基础统计信息

print(EuStockMarkets[,"DAX"])    # 输出所有行，DAX列数据，直接使用列名称访问
print(EuStockMarkets[,1])        # 输出所有行，第一列（德国DAX指数）数据，编写大型程序时显然不够直观

# 查看整个矩阵的数据，坏处是还需要手动关闭打开的页面
View(EuStockMarkets)

# rowSums()计算矩阵每一行的和生成一个新向量
rowTotal <- rowSums(EuStockMarkets)
# 以列方式将每一行和向量接在矩阵之后形成有5列的新矩阵
EuStockMarkets <- cbind(EuStockMarkets,rowTotal)  #将列绑定在一起
View(EuStockMarkets)

# colSums()计算矩阵每一列的和生成一个新向量
colTotal <- colSums(EuStockMarkets)
# 以行方式将每一行和向量接在矩阵之后形成一个有新累加和行的矩阵
EuStockMarkets <- rbind(EuStockMarkets,colTotal)  #将行绑定在一起
print(tail(EuStockMarkets))   #tail 查看尾部
#拓展
sum1=apply(EuStockMarkets, 1, sum)  #对EuStockMarkets的行（1）进行求和
sum2=apply(EuStockMarkets, 2, sum)  #对EuStockMarkets的列（2）进行求和
#sum也可以换成其他函数
mean=apply(EuStockMarkets, 1, mean)  #对EuStockMarkets的行（1）进行求均值


## 访问数据框

df  <- data.frame(symbols=c("MSFT","KO","CSCO"),price=c(40.40,40.56,23.02),currency=rep("USD",3),country=rep("USA",3),type=rep("STOCK",3))
df

class(df)

df[1,]   # 通过行列号访问数据框的一行  #与矩阵一致
df[,2]   # 通过行列号访问数据框的一列


df$price # 用列名称是更好、更直观的方式  #与列表一致


# 如果需要多次访问数据框中的数据列可以将数据框名称加入到搜索路径中
# 这样就可以直接使用数据列名称
attach(df)

currency
type

detach(df)  #解除

#########################################################################################
#心得：
#LETTERS[1:10] 用1:10 字幕A~J 为向量命名
#x[length(x)+1] <- 11;x  直接在长度后加一，并赋值
#lst[[1]]      该列表的第一个元素是一个向量symbols，结果等于lst[1]
#lst$TradeDate <- as.Date(rep("2014-4-17",3))  直接增加属性名用$，直接赋值
#lst$price <- NULL   #通过用NULL覆盖删除指定项
# rowSums()计算矩阵每一行的和， colSums()计算矩阵每一列的和

#########################################################################################

###   05.R的重要数据分析函数
# 课程内容：介绍R中很多重要、常用的数据分析函数


# 显示加载到内存中的变量和函数名称
ls()

# 显示加载到内存中的变量和函数的详细信息
ls.str()

# 计算返回向量中最大、最小的元素的索引值
x <- 1:100
which.max(x)
which.min(x)

# 如果向量中存在多个相等的最大、最小值返回的是第一个最大、最小值的索引
x <- c(1,2,5,2,1,5)
which.max(x)
which.min(x)

# 返回最大、最小值
max(x)
min(x)



# 对向量进行排序，默认采用升序排序方式
x <- c(3,5,2,8,6,9,7,4)
sort(x)      #排序
sort(x,decreasing=T)   #默认的降序参数设置为F，如果设置为T则采用降序排序


# 日期字符串向量
szDate <- c("2014-1-1","2014-3-1","2014-3-18","2014-2-14","2014-4-26","2014-4-1","2014-1-24")
# 通过as.Date()函数生成日期序列
# 注意：R语言中很多函数都可以使用向量做参数
t <- as.Date(szDate)        #日期字符串转换为日期向量
# sort()函数可以对日期序列做排序操作
t <- sort(t);t


# rev()函数对向量做逆序处理
x <- c(3,5,2,8,6,9,7,4)
x;rev(x)


# 上例中的日期型数据同样可以逆序排列
t;rev(t)


# 获取游程的信息
x <- c(1,-1,1,1,1,-1,-1,1,1,1,1,1,1,1)
y <- rle(x)  #游程 重复出现的
mode(y)  #y的类型
str(y)  #列表信息


# 按照大小对向量数据做分类处理，可以用于绘制直方图
x <- rnorm(n=10,mean=10,5)
x
breaks <- c(-20,-10,0,10,20)   # 分割数据的边界数值向量
y <- cut(x,breaks);y   #cut 通过break 分割x
summary(y)

#match()函数
# 在向量中查找指定数据（数据可用向量形式给出）,此函数返回一个和原向量等长的向量
# 存在待匹配数据的位置上标记为N(第N个待匹配数据就标记N)
x <- c(2,5,1,4,6,4,3)
match(x,4)      #x中匹配4 值为1
match(x,c(4,5))   #x中匹配4 值为1 匹配5值为2


# 计算组合数/排列数
choose(5,2)  #c52
factorial(3)  #阶乘 3!


# 符号函数
# 每日股市上涨下跌收益率有正有负可以用sign()函数生成1,-1,0组成的游程序列
cat("sign()函数运算结果：",sign(0),",",sign(3.14159),",",sign(-1024),sep="")



# 删除向量、矩阵、数据框中的NA值
x <- c(1,2,NA,4,5,NA,7,6,8,9)

y <- na.omit(x);y;   #删除向量中的na值
length(y);class(y)

dim(x) <- c(5,2);x
na.omit(x) # 删除数组中的NA值的规则是删除含有NA值的整行数据

# 交易品的历史数据中可能存在NA数值，使用na.omit()函数将会删除整条历史记录


# 检测向量、矩阵、数据框中是否包含NA数值，如果包含返回错误信息
x <- c(1,2,NA,4,5,NA,7,6,8,9)
y <- na.omit(x)
na.fail(x)
na.fail(y)   #不包含返回信息值

dim(x) <- c(2,5)
na.fail(x)


# 去除向量中的重复数据
x <- c(1,2,NA,2,5,NA,4,3,4,9)
unique(x)


# subset()从数据框中取出满足条件的子集
# 对于历史行情数据、历史交易记录可以很方便的取出其中感兴趣的数据
data(airquality)
head(airquality)
newset <- subset(airquality,Temp > 80 & Month == 5,select = c(Ozone:Day))
# subset 取出airquality 中满足Temp > 80 & Month == 5的c(Ozone:Day)数据
head(newset)

#########################################################################################
#心得：
#rev()函数对向量做逆序处理
#cut(x,breaks)  cut 通过break 分割x
#match()函数  match(x,c(4,5))   #x中匹配4 值为1 匹配5值为2
#计算组合数/排列数
#删除向量、矩阵、数据框中的NA值
#函数unique() 去除向量中的重复数据
#subset()从数据框中取出满足条件的子集

#########################################################################################

###   06.R基础绘图技术
# 课程内容： 详细介绍基础的R绘图技术

##高水平绘图函数
x <- 1:100
y <- 100 + x*5
windows(300,200);plot(y)   #window生成窗口 plot() 绘成散点图

windows(300,200);plot(y,type="l")  # type="l" 绘成直线


# 生成100个正态分布随机数并绘图
x <- rnorm(100,10,5)  #100个 均值10 标准差10
plot(x)


# 绘制1000个正态分布随机数的频数直方图
x <- rnorm(1000,30,10)
hist(x)   #hist() 直方图



# 使用核密度估计函数density()，在直方图上绘制密度曲线
# hist()函数必须设置freq参数为F才能显示密度曲线
x <- rnorm(1000,30,10)
hist(x,freq=F)
lines(density(x),col="blue")  #添加密度曲线 颜色为蓝色
box()  #添加方框


# 茎叶图很直观的表现出数据的分布情况
x <- rnorm(100,5,1)
stem(x)  #stem()茎叶图


# 绘制10个正态分布随机数的条形图
x <- rnorm(10,30,10);barplot(x)  #barplot()条形图
box() # 在当前图上加个方框


# 绘制饼图
x <-1:5;pie(x,col=rainbow(5))  #pie() 饼图  5彩虹色
box()


# 绘制箱线图
# 中间黑线为中位数位置；上下框线为上下四分位数位置；上下触须为1.5倍四分位数间距；如果有孤立点表示异常值
x <-rnorm(10,10,3);boxplot(x)  #boxplot()  箱线图


# 绘制向日葵图
data(iris)
sunflowerplot(iris[,3:4])  #sunflowerplot() 向日葵图


# 绘制矩阵或数据框的二元图
data(iris)
pairs(iris[1:4], main = "Anderson's Iris Data -- 3 species",pch = 21, bg = c("red", "green3", "blue")[unclass(iris$Species)])
#pairs() 二元图


# 绘制QQ图
# 如果向量为正态分布则数据点基本在一条直线上
x <- rnorm(500,10,5);qqnorm(x)  #qqnorm() 正态qq图


# 根据指定函数绘制指定范围的曲线图
curve(sin, -2*pi, 2*pi, xname = "t")  #curve() 曲线图  函数 下限 上限 x名


## 低水平绘图函数：在高水平绘图函数绘制的图形上做补充和修饰

# 生成50个正态分布随机数并绘图
x <- 1:50
y <- rnorm(50,10,5)
plot(x,y,type="n",xlab="数据索引",ylab="随机数点",xlim=c(1,50),ylim=c(-20,20),main="实验图",sub="随机数绘图")
#type="n" 表示不绘图 x名"数据索引" y名"随机数点" x范围c(1,50) y范围c(-20,20) 主标题"实验图" 副标题"随机数绘图"

points(x,y,col="blue") #绘制点 蓝色
lines(x,y,col="red")  #绘制线 红色

text(5,max(y),"随机数据点")           # 在指定坐标位置放置文本

# 横轴、纵轴上放置文字
mtext("横轴下方文字",side=1)          
mtext("纵轴左方文字",side=2)
mtext("横轴上方文字",side=3)
mtext("纵轴右方文字",side=4)

segments(10,10,50,-10)    # 根据起点、终点坐标绘制线段 第一个点(10,10)  第二个点(50,-10)

arrows(10,-10,40,20,angle=15,code=1) # 绘制带箭头线段，可以设置箭头角度，有几个箭头（1起点箭头、2终点箭头，3双箭头）

abline(-20,.5) # 在图上绘制直线，第一个参数为截距，第二个参数为斜率

abline(h=0,col="red") # 在图上绘制水平线(h=0)或垂直线(v=0)，可以标示临界位置

legend(0,max(y),"随机点连线")  #图例



## 坐标定位模式获得鼠标点击位置的坐标
x <- 1:50
y <- rnorm(50,10,5)
plot(x,y,type="n",xlab="数据索引",ylab="随机数点",xlim=c(1,50),ylim=c(-20,20),main="实验图")
locator(3,type="p") # 图像进入定位模式，第一个参数决定获取几个点的坐标信息，第二个参数决定绘图方式

rect(5,5,20,20) # 在已经成功绘制的图形内部绘制一个长方形

polygon(c(20,10,30,40,45),c(-10,0,15,4,-10)) # 在高级图形内部绘制多边形 5个点横坐标/纵坐标



## 生成一个绘图窗口在其中绘制图形后用savePlot()函数保存
windows()
plot(1:10)
rect(1, 5, 3, 7, col="blue")   #蓝色长方形
savePlot("test01", type="jpg",device=dev.cur(),restoreConsole=TRUE)
# 名称 类型 保存当前 保存



# 直接在jpeg设备上绘制图形，完成后使用dev.off()关闭设备，存盘退出
jpeg(file="myplot.jpeg")
plot(1:10)
rect(1, 5, 3, 7, col="blue")
dev.off()

#########################################################################################
#心得：
#plot() 散点图 type="l" 绘成直线
#hist() 直方图
#密度估计函数density()  lines(density(x),col="blue")添加密度曲线 颜色为蓝色
#barplot()条形图
#pie() 饼图
#boxplot()  箱线图
#sunflowerplot() 向日葵图
#pairs() 二元图
#qqnorm() 正态qq图
#curve() 曲线图  函数 下限 上限 x名
#横轴、纵轴上放置文字
#在图上绘制水平线(h=0)或垂直线(v=0)
#rect() 绘制长方形
#polygon()部绘制多边形
#坐标定位模式获得鼠标点击位置的坐标  locator(3,type="p")
#生成一个绘图窗口在其中绘制图形后用savePlot()函数保存

#########################################################################################

###   07.金融数据获取
# 课程内容：从雅虎金融等数据网站获取：各国股票、股指、债券、ETF基金、汇率、金属、期权等交易品种历史数据和上市公司年报数据

#加载软件包
library(quantmod)

## 不设置来源则默认从雅虎金融下载；
# 雅虎金融上大量指数品种都以"^"开头
# from,to参数设置读取历史数据的时间段
getSymbols("^GSPC",src="yahoo",from="1994-1-1",to=Sys.Date()) 
#加载"^GSPC"从"yahoo"下载时间从"1994-1-1"至今
head(GSPC) #头数据6个
tail(GSPC) #尾数据6个
class(GSPC) #类型
is.OHLC(GSPC)  #是否为OHLC  为quantmod包自带函数 (open high low close)
is.OHLCV(GSPC)  #是否为OHLCV (open high low close volume)


# 从雅虎金融读取著名的苹果公司的全部股票数据
getSymbols("AAPL",src="yahoo",from="1900-1-1",to=Sys.Date()) 
head(AAPL)
tail(AAPL)


# 从雅虎金融读取著名港股长江实业的股票数据
# 港股和大陆A股类似使用数字编号，雅虎金融上面有全球几十个市场的数据需要进行区分
# 美股不使用后缀而其他国家或地区的股票需要使用后缀:
#大陆沪市使用:".SS"，深市使用:".SZ"，香港使用:".HK"
setSymbolLookup(CJSY=list(name="0001.HK",src="yahoo"))   
# 在函数内部用列表指明股票代码和查询网站并指定一个变量名便于保存
getSymbols("CJSY",from="1900-1-1",to=Sys.Date())
head(CJSY)
tail(CJSY)


## 用字符串向量保存股票代码一次下载一组股票数据
# 下载股票数量超过5种时系统会自动暂停1秒 减轻网站负担
szSymbols <- c("MSFT","ORCL","GOOG","INTL","AAPL","CSCO","SYMC","TSLA")
getSymbols(szSymbols,src="yahoo",from="2008-1-1",to=Sys.Date()) 


# 美国10年期债券收益率
getSymbols("^TNX",src="yahoo",from="1900-1-1",to=Sys.Date()) 
head(TNX)
tail(TNX)   #收益率越高 经济越差


# ETF基金，伊斯兰地区ETF基金，2008-03-28  政治危机
getSymbols("ACWI",src="yahoo",from="1900-1-1",to=Sys.Date()) 
head(ACWI)
tail(ACWI)


# 获取美元兑日元汇率数据
# 只能获取最近1年多的汇率历史数据，并且只有收盘价
getFX("USD/JPY")  #FX  foreign exchanges  数字变大 日元贬值
head(USDJPY)
tail(USDJPY)


# 获取欧元兑美元汇率数据
getSymbols("EUR/USD",src="oanda")  #数据源"oanda" 不是雅虎
head(EURUSD)
tail(EURUSD)


# 运行这一段代码会出现错误，该数据源每次请求只能获取500天以内的数据
# 外汇是极其重要的交易品种，每天成交量超过5.3万亿美金，大型对冲基金都要操作
# 获取超过30年，每天OHLC历史数据的方法在第9课中详细介绍
getSymbols("EUR/USD",src="oanda",from="2005-01-01")


# 获取交易品当前最新的详细报价数据信息
tmp <- getQuote("AAPL");tmp
class(tmp)

# 获取财报信息
getFinancials("TSLA")
viewFin(TSLA.f)

viewFin(TSLA.f,"CF","A")    #  每年的现金流


# 获得股票的股息历史数据
getDividends("AAPL")


# 获得股票的拆分信息
getSplits("BIDU")   #0.1  一股拆10股


## 对股票进行除权除息调整
# 除权除息对于早期历史数据影响更明显
getSymbols("BIDU", from="2005-01-01", src="yahoo")
head(BIDU)
head(BIDU.a  <- adjustOHLC(BIDU))   # 默认调整方式不使用Adjusted列的数据
head(BIDU.uA <- adjustOHLC(BIDU, use.Adjusted=T)) 


# 计算除权除息之后的开盘价收盘价收益率和收盘价收益率，保持不变
head(cbind(OpCl(BIDU),OpCl(BIDU.a),OpCl(BIDU.uA)))   #OpCl 开盘收盘
head(cbind(ClCl(BIDU),ClCl(BIDU.a),ClCl(BIDU.uA)))   #ClCl 收盘收盘



## 获取期权信息
# 期权是极为重要的交易品种

BIDU.OPT <- getOptionChain("BIDU")
class(BIDU.OPT)  # 获取的期权链数据保存在列表中
BIDU.OPT         # 显示全部期权链数据量非常大  calls 看涨期权 puts 看跌期权
BIDU.OPT$symbol  # 显示期权链列表中的symbol数据
BIDU.OPT$calls   # 显示期权链列表中的看涨期权数据

#########################################################################################
#心得：
#数据下载getSymbols("^GSPC",src="yahoo",from="1994-1-1",to=Sys.Date()) 
#加载"^GSPC"从"yahoo"下载时间从"1994-1-1"至今
# 获取汇率数据 getFX()
# 获取交易品当前最新的详细报价数据信息 getQuote()
# 获得股票的股息历史数据 getDividends("AAPL")
# 获取期权信息 getOptionChain()
#对于股票 期货 等金融数据了解甚少 很多专业名词与数据实质不能很好理解

#########################################################################################

###   08.金融数据绘图与技术指标
# 课程内容：金融时间序列的绘图、quantmod软件包中的专用函数绘图、把常用技术指标、成交量等内容加入图形

# 获得数据
library(quantmod)  #后面多数函数来自这个包
getSymbols("^GSPC",src="yahoo",from="2004-1-1",to="2014-1-1")
tail(GSPC)
GSPCClose <- Cl(GSPC)  #Cl()获得收盘价
tail(GSPCClose)  

# plot()是泛型函数能够根据输入自变量的类型不同调用不同模块绘制图形
# 只能对收盘价这样的单个数据点绘图
windows()  #新建窗体
plot(GSPCClose)


## chartSeries() 绘图
# 函数可以直接接受OHLCV时间序列作为输入
windows()
chartSeries(GSPC)  #时间序列绘图


# 只用收盘价数据也没问题
windows()
chartSeries(GSPCClose)  


# chartSeries()详细参数使用
windows()
chartSeries(GSPC,
            name="标普500走势图",
            type="candlesticks",       # 蜡烛图
            subset="2012/2013",        # ISO8601风格的字符串用于表示时间范围
            TA=NULL,                   # 默认使用"addVo()"将成交量显示在图形底部，设置为NULL增加显示范围
            theme=chartTheme("white")) # 使用名为"white"的绘图主题 默认black

## 获取white绘图主题的参数
theme.white <- chartTheme("white")

# 查看绘图主题所有参数
names(theme.white)

theme.white$up.col <- "red"  #上涨
theme.white$dn.col <- "white"  #下跌
theme.white$border <- "lightgray"  #边界


windows()
chartSeries(GSPC,
            name="标普500走势图",
            type="candlesticks",
            subset="2013-6/",        # 2013年6月到最后一个数据
            TA=NULL,     
            theme=theme.white)       # 使用参数经过修改的绘图主题


# 使用文字描述的取子集功能
windows()
chartSeries(GSPC,
            name="标普500走势图",
            show.grid = T,           # 无论是否使用此参数都看到
            type="candlesticks",
            subset="last 3 months",  # 使用文字描述，最后3个月时间序列值
            TA="addVo()",            # 加入成交量数据
            theme=theme.white)       



# reChart()的大多数参数和chartSeries()相似用于对最新绘制的图形做修改
reChart(theme=chartTheme("black"),  #主题改为black
        subset="last 6 months")     #数据改为"last 6 months"


# 加入多个技术指标
windows()
chartSeries(GSPC,
            name="标普500走势图",
            show.grid = T,             # 无论是否使用此参数都看到
            type="candlesticks",
            subset="last 2 quarters",  # 使用文字描述，最后2个季度的时间序列值
            TA="addVo();addSMA(20);addBBands(20,3)", # 加入简单移动平均线和布林线指标，不是指标函数
            theme=theme.white)         # 使用参数经过修改的绘图主题


## chartSeries()函数绘制出的图形通过zooom()函数做缩放操作
# n   每次调用函数时交互图形变化的倍数
# eps 点击鼠标几次图形发生改变
zooom(n=1,eps=2)


# 放大2012年的历史数据
zoomChart("2012")

# 放大2012年9月的历史数据，第三轮QE（量化宽松）启动
zoomChart("2012-9")

# 直接使用addCCI()函数在当前图形上添加新技术指标
addCCI(20)  #周期20 CCI  商品通道指标

## 保存绘制的图形
windows()
chartSeries(GSPC,
            name="标普500走势图",
            show.grid = T,             # 无论是否使用此参数都看到
            type="candlesticks",
            subset="last 2 quarters",  # 使用文字描述，最后2个季度的时间序列值
            TA="addVo();addSMA(20);addBBands(20,3)", # 加入简单移动平均线和布林线指标，不是指标函数
            theme=theme.white)         # 使用参数经过修改的绘图主题  


# 默认使用的是"pdf"参数，图形被保存在当前目录下
# 运行时经常出错
saveChart(.type="jpeg",dev=dev.cur())



# 使用jpeg()和dev.off()函数配合保存绘制的图形到JPEG文件中
jpeg("GSPC.jpeg")
chartSeries(GSPC,
            name="标普500走势图",
            show.grid = T,             # 无论是否使用此参数都看到
            type="candlesticks",
            subset="last 2 quarters",  # 使用文字描述，最后2个季度的时间序列值
            TA="addVo();addSMA(20);addBBands(20,3)", # 加入简单移动平均线和布林线指标，不是指标函数
            theme=theme.white)         # 使用参数经过修改的绘图主题  
dev.off()

#########################################################################################
#心得：
# plot()是泛型函数能够根据输入自变量的类型不同调用不同模块绘制图形
# chartSeries() 绘图 函数可以直接接受OHLCV时间序列作为输入
# chartSeries()详细参数使用 和修改
# 使用文字描述的取子集功能 subset="last 3 months", 使用文字描述，最后3个月时间序列值
# reChart()的大多数参数和chartSeries()相似用于对最新绘制的图形做修改
# chartSeries()函数绘制出的图形通过zooom()函数做缩放操作
# 复习图片保存

#########################################################################################




















