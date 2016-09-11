

#  用R做线性回归

#一元回归
x=c(18,23,25,35,65,54,34,56,72,19,23,42,18,39,37)  #年龄数据
y=c(202,186,187,180,156,169,174,172,153,199,193,174,198,183,178)  #对应心率数据
plot(x,y)  # 绘制散点图

fm=lm(y~x)  #做函数
abline(fm)  #做出函数fm的回归线
fm   #查看fm

coef(fm)  #回归系数
resid(fm)   #残差值
summary(fm)  #输出fm统计结果
plot(fm)  #做出fm的散点图

#置信区间预测

#点预测

predict(fm,data.frame(x=50))  #x=50时 y的预测值
#区间预测

sx=sort(x)  #自变量排序
pred=predict(fm,data.frame(x=sx),interval = "confidence") #计算置信区间
conf=predict(fm,data.frame(x=sx),interval = "prediction") #计算预测区间
plot(x,y);abline(fm)  #散点图和回归线
lines(sx,conf[,2]);lines(sx,conf[,3])   #95%置信区间
ines(sx,pred[,2],lty=3);lines(sx,pred[,3],lty=3)   #95%预测曲线


#二次回归

x=c(100,200,300,450,600,800,1000)  #高度
y=c(253, 337,395,451,495,534,574)  #距离

lm.1=lm(y ~ x)					#一次模型	y=a+bx
lm.2=lm(y ~ x+I(x^2))				#二次模型	y=a+bx+cx^2
lm.3=lm(y ~ x+I(x^2)+I(x^3))			#三次模型	y=a+bx+cx^2+d

#下面用summary给出三种模型的拟合结果
summary(lm.1)$coef
summary(lm.2)$coef
summary(lm.3)$coef

#下面作图来分析
plot(x,y)
lines(x,fitted(lm.1),lty=1)
lines(x,fitted(lm.2),lty=2)
lines(x,fitted(lm.3),lty=3)
legend(700,400,c("直线","二次曲线","三次曲线"),lty=1:3)

summary(lm.1)$r.squared
summary(lm.2)$r.squared
summary(lm.3)$r.squared



#  方差分析

#单因素方差分析
PlantGrowth  #R自带植物生长数据
unstack(PlantGrowth)  #将数据安属性拆开
oneway.test(weight ~ group, data=PlantGrowth, var.equal=T ) #作单因素方差分析检验

anova(lm (weight ~ group, data=PlantGrowth))  #anova函数要在lm基础上分析
aov(veight ~ group, data=PlantGrowth)
summary(aov(weight ~ group, data=PlantGrowth)) #用summary(aov)代替anova(lm)

#双因素方差分析
range=c (582,562,653,491,541,516,601,709,392,758,582,487 )
A=c (1,1,1,2,2,2,3,3,3,4,4,4)
B=c (1,2,3,1,2,3,1,2,3,1,2,3)  #数据

plot(range~A,pch~B)  #做出A的图
legend(1.5,750,legend=l:3,pch=B)  #添加图的示例

par(mfrow=c(1,2))   #定义一行两列图表
boxplot(range~A,xlab="A"); boxplot(range~B,xlab="B")   #分别做出A，B的箱线图

par(mfrow=c(1,1))
A=factor(A)  ; B=factor(B)  #将A,B声明成因子
range.aov <- aov(range ~ A + B)
summary(range.aov)  #做出双因素方差分析结果

#考虑交互作用的双因素分析

Y=c ( 60.7,61.1,61.5,61.3,61.6,62.0,61.7,61.1,61.5,60.8,61.7,
      61.2,62.2,62.8,62.1,61.7, 60.6,60.3,60.6,61.0,61.4,61.5,60.7,60.9 )
A=c (1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,3,3,3,3,3,3,3,3 )
B=c (1,1,2,2,3,3,4,4, 1,1,2,2,3,3,4,4, 1,1,2,2,3,3,4,4)
A=factor (A);B=factor (B)  #将A，B转化为因子
rate.aov <- aov (Y ~ A + B + A*B)  #等价于rate.aov <- aov (Y ~ A:B)
summary(rate.aov)  #进行方差分析





