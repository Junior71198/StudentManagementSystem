Exception handling : هي طريقة تستخدم للتحكم ف الايرورز اللي بتحصل معانا ف الكود عن طريق استخدام 
try and catch 
try: دي بنحط فيها الكود بتاعنا الطبيعي جدا
catch: ودي اللي بتشوف الكود فيه ايرور معين ولا لأ وكمان تقدر تقولنا ايه نوع الايرور 
Example :
try {
int x =5 ;
int y=0 ;
int z = x/y;
Console.WriteLine(z);
}
Catch(Exception ex) 
{
Console.WriteLine(ex.massege);
}

هنا الناتج هيقولي ان عمدك ايرور وهيطلعلي رسالة الايرور
