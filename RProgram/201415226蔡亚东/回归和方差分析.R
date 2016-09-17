######回归分析####
##例7.1最大利率和年龄的关系
###读入数据
x=c(18,23,25,35,65,54,34,56,72,19,23,42,18,39,37)
y=c(202,186,187,180,156,169,174,172,153,199,193,174,198,183,178)
plot(x,y)###绘制散点图
fm=lm(y~x)##拟合线性回归模型##lm是函数
plot(x,y);abline(fm)###在散点图上，添加回归线
coef(fm)##得到回归系数
resid(fm)##求残差
summsy(fm)###fm的统计结果
plot(fm)  #得到fm的散点图

###置信区间####
###点预测##
predict(fm,data.frama(x=50))##即x=50时，y的预测值为170.2.
###区间预测###
sx=sort(x)###将x排序
pred=predict(fm,data.frame(x=sx),interval = "confidence") #interval = "confidence"默认计算均值的置信区间
conf=predict(fm,data.frame(x=sx),interval = "prediction") #interval = "prediction"计算构值预测区间
##一般构值的预测区间比均值的预测区间大一点
plot(x,y);abline(fm)  #散点图和回归线
lines(sx,conf[,2]);lines(sx,conf[,3])   #95%置信区间###sx,conf[,2]均值的预测区间下区间；lines(sx,conf[,3]上区间
lines(sx,pred[,2],lty=3);lines(sx,pred[,3],lty=3)
####例7.4
#二次回归
x=c(100,200,300,450,600,800,1000)  #高度
y=c(253, 337,395,451,495,534,574)  #水平距离
###模型分析
lm.1=lm(y ~ x)					           #一次模型	y=a+bx
lm.2=lm(y ~ x+I(x^2))				       #二次模型	y=a+bx+cx^2###I是函数
lm.3=lm(y ~ x+I(x^2)+I(x^3))			 #三次模型	y=a+bx+cx^2+d
###做出拟合结果##
summary(lm.1)$coef
summary(lm.2)$coef
summary(lm.3)$coef
##画图分析
plot(x,y)
lines(x,fitted(lm.1),lty=1)
lines(x,fitted(lm.2),lty=2)
lines(x,fitted(lm.3),lty=3)
legend(700,400,c("直线","二次曲线","三次曲线"),lty=1:3)
######三次抛物线的拟合得更好
summary(lm.1)$r.squared#?
summary(lm.2)$r.squared#?
summary(lm.3)$r.squared#?


####方差分析
#单因素方差分析
data(PlanGrowth)	#数据
unstack(PlantGrowth)	#分组
oneway.test(weight~group,data=PlantGrowth,var.equal = T)	
anova(lm(weight~group,data=PlantGrowth))###推荐使用	
summary(aov(weight~group,data=PlantGrowth))	

#两因素方差分析
#不考虑两个因素交互作用的情况下
range=c(582,562,653,491,541,516,601,709,392,758,582,487 )
A=c(1,1,1,2,2,2,3,3,3,4,4,4)
B=c(1,2,3,1,2,3,1,2,3,1,2,3)	
plot(range~A,pch=B)   #pch 不同符号表示
legend(1.5,750,legend=1:3,pch=B)   #添加图例
###做出箱线图
par(mfrow=c(1,2))	#一行两个图
boxplot(range~A,xlab="A")	#A因素的箱线图
boxplot(range~B,xlab="B")	#B因素的箱线图
#进行方差分析
par(mfrow=c(1,1))
A=factor(A)  #把A变量转化为因子
B=factor(B)  #把B变量转化为因子
range.aov<-aov(range~A+B)	#方差分析
summary((range.aov))  #得到分析结果
#2.双因素考虑交互作用
Y=c(60.7,61.1,61.5,61.3,61.6,62.0,61.7,61.1,61.5,60.8,61.7,61.2,62.2,62.8,62.1,61.7, 60.6,60.3,60.6,61.0,61.4,61.5,60.7,60.9 )
A=c(1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,3,3,3,3,3,3,3,3)
B=c(1,1,2,2,3,3,4,4,1,1,2,2,3,3,4,4,1,1,2,2,3,3,4,4)	#读入数据
A=factor(A)	#将A因素转化为因子
B=factor(B)	#将B因素转化为因子
#进行方差分析
rate.aov= aov(Y~A+B+A*B)	#进行方差分析A*B表示交互作用
summary(rate.aov)	#得到分析结果








