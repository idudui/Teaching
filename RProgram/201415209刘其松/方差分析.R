#单因素方差分析

#对数据分组
unstack(PlantGrowth)
#做单因素分析
oneway.test(weight~group,data=PlantGrowth,var.equal = T)
anova(lm(weight~group,data=PlantGrowth))
summary(aov(weight~group,data=PlantGrowth))


#两个因素方差分析
#不考虑两个因素交互作用

#读入数据
range=c(582,562,653,491,541,516,601,709,392,758,582,487 )
A=c( 1, 1, 1,2,2,2,3,3,3,4,4,4)
B=c(1,2,3,1,2,3,1,2,3,1,2,3 )

#画图分析
plot(range~A,pch=B)   #pch不同符号表示
legend(1.5,750,legend=1:3,pch=B)   #添加图例

#画ab箱线图
par(mfrow=c(1,2))
boxplot(range~A,xlab="A")
boxplot(range~B,xlab="B")

#方差分析
par(mfrow=c(1,1))
A=factor(A)  #A转化为因子
B=factor(B)  #B转化为因子
range.aov=aov(range~A+B)
summary((range.aov))  #提取重要信息


#双因素考虑交互作用
#读取数据
Y=c(60.7,61.1,61.5,61.3,61.6,62.0,61.7,61.1,61.5,60.8,61.7,61.2,62.2,62.8,62.1,61.7, 60.6,60.3,60.6,61.0,61.4,61.5,60.7,60.9 )
A=c(1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,3,3,3,3,3,3,3,3)
B=c(1,1,2,2,3,3,4,4,1,1,2,2,3,3,4,4,1,1,2,2,3,3,4,4)
#AB转化为因子
A=factor(A) 
B=factor(B)
#方差分析
rate.aov= aov(Y~A+B+A*B)
summary(rate.aov)
