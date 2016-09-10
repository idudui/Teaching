
#读入最大心率和年龄数据
x=c(18,23,25,35,65,54,34,56,72,19,23,42,18,39,37)
y=c(202,186,187,180,156,169,174,172,153,199,193,174,198,183,178)


#画图分析
plot(x,y)       #散点图
fm=lm(y~x)      #拟合线性回归模型
abline(fm)      #绘制回归线
coef(fm)        #得到回归系数
resid(fm)       #得到残差值
summary(fm)     #所有输出结果
plot(fm)        #回归分析检验


#置信区间预测
# 1.点预测
#x=50时y的预测值
predict(fm,data.frame(x=50))


#2.区间预测
#95%预测曲线
sx=sort(x)
pred=predict(fm,data.frame(x=sx),interval = "confidence")
conf=predict(fm,data.frame(x=sx),interval = "prediction")
plot(x,y);abline(fm)
lines(sx,conf[,2]);lines(sx,conf[,3])
lines(sx,pred[,2],lty=3);lines(sx,pred[,3],lty=3)


#二元线性回归
#读入高度距离数据
x=c(100,200,300,450,600,800,1000)
y=c(253, 337,395,451,495,534,574)

#创建模型
lm.1=lm(y ~ x)				          	#一次模型	y=a+bx
lm.2=lm(y ~ x+I(x^2))			    	#二次模型	y=a+bx+cx^2
lm.3=lm(y ~ x+I(x^2)+I(x^3))			#三次模型	y=a+bx+cx^2+dx^3

#用summary给出三种模型的拟合结果:
summary(lm.1)$coef    #一次模型	y=a+bx	通过t检验
summary(lm.2)$coef    #二次模型	y=a+bx+cx^2	通过t检验
summary(lm.3)$coef    #三次模型	y=a+bx+cx^2+dx^3		通过t检验


#作图分析
plot(x,y)
lines(x,fitted(lm.1),lty=1)
lines(x,fitted(lm.2),lty=2)
lines(x,fitted(lm.3),lty=3)
legend(700,400,c("直线","二次曲线","三次曲线"),lty=1:3)
summary(lm.1)$r.squared
summary(lm.2)$r.squared
summary(lm.3)$r.squared
#可知三次模型	y=a+bx+cx^2+dx^3	拟合度更高
