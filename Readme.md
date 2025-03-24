# 初识

`.NetFramWork `框架是`.Net `平台不可或缺的一部分，提供了稳定的运行环境保证我们基`.Net` 平台开发的应用能够稳定运行。

![img](assets/1740793541771-96d61b0e-2512-4c05-9646-5baacdb56e47.jpeg)

## VS快捷键

1. 快速对齐代码：鼠标点中某行，`Ctrl+K+D`，要求代码中不能有错误。
2. 转到帮助文档：`F1`
3. 保存`Ctrl+S`
4. 撤销：`Ctrl+Z`
5. 选中整行代码：SHIFT+END（往后选）,SHIFT+HOME（往前选）

## VS的基本操作

### 调整字体

`Ctrl+滚轮`调整字体大小。

### 设置行号

在工具>>选项卡中：

![img](assets/1736580380896-e8e272ee-1c36-479f-af20-2f30eeadced3.png)

### 设置字体

在工具>>选项卡中：

![img](assets/1736580585236-d737c333-8574-42a2-9e34-68d0032304ff.png)

### 主题颜色设置

![img](assets/1736580764753-ec4c0e7f-b629-4cbb-9e27-ec1c27ebbee3.png)

### 恢复原设置

![img](assets/1736580871596-a359a52a-da43-4b6f-97c2-439dc0b3283b.png)

### 检查语法

运行代码`F5`前应先进行语法检查`F6`.

![语法检查](assets/1736580468255-62a3b683-c402-4e43-867c-8b8e92469c5a.png)

## 第一个示例

标点符号用英文，简单语句结束用分号。`{}`包围起来的语句叫块，块后面不能跟分号。

```csharp
using System;
//工作空间 ，门牌号
namespace worklzb
{
    //类型
    class lzb
    {
        /// 应用程序的主入口点。 <summary>
        /// 函数方法
        /// </summary>
        static void Main()
        {
            Console.WriteLine("我的世界");//向屏幕输出文字我的世界
            string str = Console.ReadLine();//存储用户输入的值
            Console.WriteLine(str);//输出用户输入的值
        }
    }
}
```

| Console类常用方法    | 作用                                                         |
| -------------------- | ------------------------------------------------------------ |
| Console.WriteLine( ) | 将字符串打印到屏幕，结尾跟一个换行符                         |
| Console.Write( )     | 将字符串打印到屏幕                                           |
| Console.ReadLine( )  | 返回用户输入的**内容 ，string类型**                          |
| Console.ReadKey( )   | 暂停窗口，直到用户输入内容。参数为true时，不显示用户输入内容。 |

## 注释

注释作用`解释代码`或`注销代码`。

### 单行注释

在代码前面加上`//`。

![单行注释](assets/1736581923548-b4904275-335b-4925-b4cf-9b7aa5862996.png)

### 多行注释

用`/**/`将代码包含起来。

![多行注释](assets/1736582127071-e6b19a09-8574-481d-9192-5e369d99514a.png)

### 文档注释

多用来解释书写的类以及方法，使用`///`表示。

![文档注释](assets/1736582474445-1639125f-7db0-4b99-bd3f-fd2f8d5d91d5.png)



# 变量与常量

变量与常量是用来在计算机中存储数据。变量需先声明后赋值最后参与运算。

## 变量类型

变量类型包括预定义类型和自定义类型。

```mermaid
flowchart TD
A(预定义类型)--> B[(简单类型)]
A --> C(string)
A --> D(Object)
B-->E(数值类型)
E --> 整数类型
E --> 浮点类型
整数类型 -->int
整数类型 -->byte
整数类型 -->short
整数类型 -->long
浮点类型 --> decimal
浮点类型 --> float
浮点类型 --> double
B-->F(非数值类型)
F-->bool
F --> char
```

:book:变量类型详解

:one:整数类型

:red_circle:有符号指的是可存放正负数；位数指的是存放二进制数字长度；不能赋值小数。

| 整数类型 | 备注           |
| -------- | -------------- |
| long     | 64位有符号整数 |
| int      | 32位有符号整数 |
| short    | 16位有符号整数 |
| `byte`   | 8位无符号整数  |

:two:浮点数

| 类型         | 关键字  | 备注                                                         |
| ------------ | ------- | ------------------------------------------------------------ |
| 单精度浮点数 | float   | 精度大约 6-9 位，4字节,数字后面+f/F，可赋值**整数以及小数**  |
| 双精度浮点数 | double  | 精度15-17 位，8字节,可赋值**整数以及小数**                   |
| 十进制货币数 | decimal | 位数更小，适合储存货币值，16字节，数字后面+m/M，可赋值**整数以及小数** |

:three:其他

| 类型   | 关键字 | 备注                                     |
| ------ | ------ | ---------------------------------------- |
| 字符串 | string | 存放0~多个字符文本，用双引号包裹起来     |
| 单字符 | char   | 仅能存放一个字符，不能为空，用单引号包裹 |
| 布尔值 | bool   | true或false                              |
| 枚举   | enum   | 用户自定义的数据类型,默认用Int数据存储。 |

```csharp
byte a = 255;//最大255，2的8次方-1
short b = 266;
long c = 5666000000;
//小数类型变量可以直接赋值整数
float a = 1;
decimal b = 11;
double c = 10;
//小数类型变量赋值为小数时需要注意后缀
//无后缀为double类型
float num1 = 1.0f;//使用f强制转换为float
decimal num2 = 10.0m;//使用m强制转换为decimal
double num3 = 10.0;//不加后缀默认为double
char cha = 'a';//单引号，且不能为空
//错误示范
char cha = ''//空字符
```

## 命名规范

:one: 变量名称要有意义

:two: 不能与关键字冲突。

:three:以字母，`_`,`@`开头，后面跟任意`数字`，`字母`，`下划线_`。

```csharp
string 1num = 1; //错误
string num_1 = 2; //正确
string a = 2;//无意义
```

:four:大小写敏感

```csharp
int num = 0;
int Num = 1;//二者不一致
```

:five:不能重复声明

:six:变量，字段推荐`Camel(骆驼)`命名规范：首单词字母小写，其余单词首字母大写。

* `highSchool`

* `dark_Key`

:seven:类，方法，枚举名推荐`Pascal`命名规范：所有单词首字母大写

## 变量的声明与初始化



声明变量：意在指定数据类型以及名称，告诉编译器它的数据类型，给它分配多大的内存空间，以及存放怎样的数据。

```csharp
// 数据类型 变量名
int a;//默认 0
string str; //默认 null，不在内存中开辟空间
bool b;//默认false
int d, e, f, g;//连续声明变量,要求变量类型一致
```

变量的初始化及在声明变量的同时进行赋值。

```csharp
int a = 100, b = 0, c = 20;
//连续声明以及赋值,要求变量类型一致
```

声明变量`a`（默认0）,并将值100赋值给`a`。底层是在内存中开辟一个存储整数的空间，并将100存放其中。

## var推断类型

C#是一门强类型语言，在代码中必须对每一个变量的类型有个明确的定义，`var`是推断类型（匿名类型），根据值推断变量类型。

```csharp
var a = "das";
var num = 12;
var doubleNum = 12.0;
//GetType()获取当前实例的类型
Console.WriteLine(a.GetType());
Console.WriteLine(num.GetType());
Console.WriteLine(doubleNum.GetType());
```

:red_circle:缺陷：必须初始化

```csharp
var a;//错误,声明时必须赋值
var a = 1;
a = "";//错误，类型确定后不再改变
```

## 变量作用域

### 局部变量

在方法体`形参`、以及在块`{}`之间声明的变量称为局部变量。

:one:从声明的大括弧开始到对应的括弧结束，这整个范围内可以访问使用，超出则无法使用。

```csharp
static void Main(string[] args)
{
    { int a = 1; }
    Console.WriteLine(a);//超出范围，无法访问
}
```

:two:方法的参数也属于局部变量（方法调用结束后，会释放局部变量占用的内存空间，销毁局部变量）

```csharp
static void Main(string[] args)
{
    int a = 1;
    int b = 2;
    //将Main函数中的a，b储存的值赋值形参a,b，变量名虽相同但不冲突
    Range(a, b);
    Console.WriteLine(a);//1，只能访问到本方法中的a
    Console.WriteLine(b);//2
}
public static void Range(int a, int b)
{
    a++;
    b++;
}

```

:red_circle:注意引用传递参数

```csharp
//在ChangeArr()方法中形参存储的是引用地址，形参与实参指向同一个地址
//方法结束后堆中的数据被更改了
static void Main(string[] args)
{
    int[] arr = { 1, 2, 4 };
    ChangeArr(arr);//将引用地址传给方法中的局部变量
    Console.WriteLine(arr[0]);
}
static void ChangeArr(int[] arr) 
{
    arr[0] = 100;
}
```

### 静态字段模拟全局变量

Main函数中声明的变量只能在Main函数中使用，自定义函数是无法访问到。我们可以在类中通过声明静态字段来模拟全局变量，该类中所有方法都可以访问到，且结束后不会销毁变量。

```csharp
internal class Program
{
    public static int _number;
    static void Main(string[] args)
    {
        //Main函数中调用Print
        Print();
    }
    //自定义方法
    public static void Print()
    {
        _number = 2025;//在本类中调用，类名可省略
        Console.WriteLine("{0}年大吉大利",_number);
    }
}
```

## 常量

常量是不可以多次赋值的变量，要求声明时必须初始化。

```csharp
const 变量类型 变量名 = 值
const int num = 10;
//常量不能重新赋值
num = 20;//错误，赋值号左边必须是变量...
```

# 运算符

## 赋值运算符

`=`，把等号右边的值赋值给左边变量，即将值存储在内存中。

由=连接的表达式叫做赋值表达式。

:one:简单运算符

| 简单赋值运算符 | 描述                   | 实例                            |
| -------------- | ---------------------- | ------------------------------- |
| =              | 把右边的值赋给左边变量 | C = A + B 将把 A + B 的值赋给 C |

:two:复合赋值运算符

变量在使用复合赋值运算符之前要初始化。

| 复合赋值运算符 | 实例                    |
| -------------- | ----------------------- |
| +=             | C += 2 相当于 C = C + 2 |
| -=             | C -= 2相当于 C = C - 2  |
| *=             | C *= 2相当于 C = C * 2  |
| /=             | C /= 2 相当于 C = C / 2 |
| %=             | C %= 2 相当于 C = C % 2 |

```csharp
int number = 10; //number的值是10。
```

变量可以重新赋值，取而代之的是新值。

```csharp
int number = 10; // number值是10
number = 20;//重新赋值后number值是20
```

下面是复合运算符示例：

```csharp
 int num = 10;
 num += 5;//15，num = num + 5
 num *= 2;//30,num = num * 2
 num %= 4;//余2,num = num % 4
//=后面可视为一个整体
int n = 0;
n += 5 + 3 * 2 + 6;
// n =17
```

## 算数运算符

假设变量 **A** 的值为 `10`，变量 **B** 的值为 `20`，则：

| 运算符 | 描述                                     | 实例             |
| ------ | ---------------------------------------- | ---------------- |
| +      | 把两个操作数相加                         | A + B 将得到 30  |
| -      | 从第一个操作数中减去第二个操作数         | A - B 将得到 -10 |
| *      | 把两个操作数相乘                         | A * B 将得到 200 |
| /      | 分子除以分母                             | B / A 将得到 2   |
| %      | 取余运算符，整除后的余数                 | B % A 将得到 0   |
| ++     | 自增运算符，整数值增加 1（操作数是变量） | A++ 将得到 11    |
| --     | 自减运算符，整数值减少 1（操作数是变量） | A-- 将得到 9     |

:red_circle:整数类型相除，若不能整除，返回值仍是整型。

:red_circle:模`%`与`/`以及`*`优先级相同。

:red_circle:对于像`++`，`--`只需要一个操作数完成的运算叫一元运算符，对于`+`，`-`，`*`,`/`,`%`需要两个操作数完成的运算叫做二元运算符。一元运算符的优先级比二元运算符级别要高。

C#没有提供幂次方的运算符，可通过`Math.Pow()`计算一个数的幂次方，此方法返回一个`double`值。

```csharp
int num = 2;
int bigNum = Convert.ToInt32(Math.Pow(num, 3));
Console.WriteLine(bigNum);
```

:one:求和取余

```csharp
int smallNum = 3;
int bigNum = 7;
Console.Write("7与3的和是{0}", smallNum+bigNum);//10
Console.Write("\n7与3的余数是{0}",bigNum%smallNum);//1
Console.Write("\n7与3的商是{0}",bigNum/smallNum);//2
```

:two:计算圆面积。

```csharp
//方法一：
do
{
    try //try—catch捕获异常
    {
        Console.WriteLine("请输入圆面积");
        //将用户输入的文本转换为double类型
        double r = double.Parse(Console.ReadLine());
        double area = _pi * r * r;//计算圆面积
        string str = area.ToString("0.00");
        //0.00为format参数，要求保留两个小数点
        area = double.Parse(str);
        Console.WriteLine("圆的面积是{0}", area);
        return;
    }
    catch 
    {
        Console.WriteLine("输入非法字符，请重新输入");
        continue;
    }
    
} 
while (true);
//方法二：平方公式计算
int r = 5;
double area = Math.Pow(r, 2) * 3.14;//pi*r^2
Console.WriteLine("半径为5的圆面积是：{0}",area);
```

:three:价格计算

```csharp
int shirt = 35 , trousers = 120;//T恤单价35,裤子单价120
int price = shirt * 3 + trousers * 2;//总价格
double discount = price * 0.88; //打折后价格，隐式类型转换
Console.WriteLine("总价格是{0},\n打折后的价格是{1}",price,discount);
```

:four:计算`107653秒`是几天几小时几分钟几秒？(利用`int/int`,数字类型仍是`int`)

```csharp
int days = 107653 / 86400;//总天数，一天96400秒
int seconds = 107653 % 86400;//剩余不足整数天秒数
int hours = seconds / 3600;//整小时,1h =3600s
seconds = seconds % 3600;//剩余不足整小时秒数
int minutes = seconds / 60;//整分钟,1min = 60s
seconds = seconds % 60;//剩余不足整分钟秒数
Console.WriteLine("107653秒是{0}天{1}小时{2}分钟{3}秒",days,hours,minutes,seconds);
//107653秒是1天5小时54分钟13秒
```

:five:交换变量

```csharp
int a = 3;
int b = 5;
a = b-a;//利用二者差值
b = b - a;
a = a + b;
Console.Write("a={0},b={1}",a,b);
//output a=5,b=3
```

:six:前++与后++

```csharp
int a = 10;
int b = 10 + a++;//b=20,a =11
int c = 10;
int d = 10 + ++c;//d = 21,c =11
int e = 5;
Console.WriteLine(e++);//5
Console.WriteLine(++e);//7
```

不论`前++`或`后++`，变量自身都会+1，区别在于，参与运算时，`前++`会先进行自增，后参与运算；而`后++`会先运算，然后进行自增运算。

:seven:一元运算符优先级

```csharp
int a = 10;
int num = a++ + a * 10 + ++a + a--;
         // 10 + 11*10+12 + 12,a = 11
		// a*10可看作 +a*10,虽然乘法优先级低，但 +-(正负)也是一元运算符，会先计算a的值。最后执行乘法运算
Console.WriteLine(num);//144
Console.WriteLine(a);//a=11
```

## 关系运算符

关系运算符时描述两个事物之间的关系，返回一个Bool值，`True`或`False`。由关系运算符连接的表达式叫做关系表达式。

| 运算符 | 描述                                                         | 实例              |
| ------ | ------------------------------------------------------------ | ----------------- |
| ==     | 检查两个操作数的值是否相等，如果相等则条件为真。             | (A == B) 不为真。 |
| !=     | 检查两个操作数的值是否相等，如果不相等则条件为真。           | (A != B) 为真。   |
| >      | 检查左操作数的值是否大于右操作数的值，如果是则条件为真。     | (A > B) 不为真。  |
| <      | 检查左操作数的值是否小于右操作数的值，如果是则条件为真。     | (A < B) 为真。    |
| >=     | 检查左操作数的值是否大于或等于右操作数的值，如果是则条件为真。 | (A >= B) 不为真。 |
| <=     | 检查左操作数的值是否小于或等于右操作数的值，如果是则条件为真。 | (A <= B) 为真。   |

## 逻辑运算符

由逻辑运算符连接的表达式叫做逻辑表达式。在逻辑表达式两边一般放的时关系表达式或布尔值，结果仍是布尔值。

假设A为真，B为假

| 运算符 | 描述                                                         | 实例              |
| ------ | ------------------------------------------------------------ | ----------------- |
| &&     | 逻辑与运算符。如果两个操作数都真，则条件为真。               | (A && B) 为假。   |
| \|\|   | 逻辑或运算符。如果两个操作数中有任意一个为真，则条件为真。   | (A \|\| B) 为真。 |
| !      | 逻辑非运算符。用来逆转操作数的逻辑状态。如果条件为真则逻辑非运算符将使其为假。 | !(A && B) 为真。  |

:one:简单示例

```csharp
bool a = 2 > 1; //true
bool b = 1 == 2;//false
Console.WriteLine(a && b);//false
Console.WriteLine(a || b);//true
Console.WriteLine(!(a && b));//true
```

:two:判断是否为闰年（`逻辑与`优先级比`逻辑或`优先级高）

```csharp
Console.WriteLine("请输入一个年份");
int year = Convert.ToInt32(Console.ReadLine());
//能被400整除或能被4整除而不能被100整除
bool isRun = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
//不加括弧不出错，为了美观，易识别 我们要添加括弧
Console.WriteLine("{0}年是不是闰年-{1}",year,isRun);
```

## 其他运算符

### 连字符`+`

`+`只要一边是字符串，便可以起连接作用，表达式返回一个字符串。

```csharp
string name = "Limou";
int number = 10;
Console.Write("你好, "+ name+"你的工号是"+number);//你好, Limou你的工号是10
```

### 占位符

使用连接符繁琐时使用占位符，先挖坑再填坑。`{}`中填的是参数列表的索引值，且要求索引值不能溢出。

`Console.Write(stringFormat,params object[] args);`

```csharp
int a = 1;
int b = 2;
int c = 3;
Console.WriteLine("第一个数字是{1},第二份数字是{2},第三个数字是{2}",a,b,c);
//output 第一个数字是2,第二份数字是3,第三个数字是3
//a,b,c索引值分别为0，1，2。
string name = "张三";
string sex = "男";
int age = 26;
string telNumber = "001-12345";
Console.Write("我叫{1},我今年{2}岁了，性别{3},电话号码{0}",telNumber,name,age,sex);
```

格式化保留2位小数，按照`{索引:0.00}`格式写即可。

```csharp
double bigNum = 7;
int smallNum = 3;
Console.WriteLine("大数是{0},小数是{1:0.00}",bigNum,smallNum);
//大数是7,小数是3.00
```

### 转义符

转义符是指`\`后跟一个字符，组成一个特殊意义的字符，但`\`不是跟任意字符连接都有意义。

| 转义符     | 作用                                       |
| ---------- | ------------------------------------------ |
| \n——换行符 | 换行，\n要占满一行，把后面的内容挤到下一行 |
| \\"        | 表示英文半角双引号                         |
| \t——制表符 | 用来对齐                                   |
| \b——退格键 | 删除前一位字符，放到字符串两边无效         |
| \\\        | 单纯表示\                                  |

:one:换行符

```csharp
Console.WriteLine("艳阳天那么风光好，\n红的花儿是绿的草,\n乐乐呵呵向前跑，\n踏遍青山人未老");
/*艳阳天那么风光好，
红的花儿是绿的草,
乐乐呵呵向前跑，
踏遍青山人未老*/
```

:two:制表符

```csharp
 Console.WriteLine("张三，\t李四");
 Console.WriteLine("王五，\t赵六");
//张三，  李四
//王五，  赵六
```

:three:退格符

```csharp
Console.WriteLine("AB\bF\b"); //AF
//对于中文似有BUG
```

### @符号

1. 取消`\`的转移作用，让`\`单纯表示`\`。

```csharp
Console.WriteLine(@"C:\Users\Administrator\Desktop");
```

1. 将字符串按照编辑的原格式输出。

```csharp
Console.WriteLine(@"白日依山尽，
黄河入海流");
//白日依山尽，
//黄河入海流
```

# 枚举

用户定义的有限的常量集合，用来规范开发。

1. 对于同一有意义的值，在协作开发中，不同的人定义不同的类型，在后续传参过程中，可能会导致变量类型或值不匹配，增大开发难度
2. 给不同的数字赋予不同的名称，使得代码可读性高

一般声明在在命名空间与类之间，该命名空间所有的类都可以使用枚举。

```csharp
//声明一个枚举类型，名称为用户赋予常量的别名
[public] enum 枚举名
{
    //枚举变量
    常量名称1，
    //常量在内存中用int型存储，默认是一组0~n的常量
    常量名称2，，
    常量名称3，
    ...
    常量名称n
}
```

:one:`[public]`:访问修饰符，表示访问权限等级，`public`访问权限最高，哪都可以访问，`[]`代表访问修饰符可省略。

:two:`enum`声明枚举类型关键字

:three:枚举名符合`Pascal`命名规范。

枚举本质就是一个变量类型，只是在声明赋值枚举变量前，要求先声明`枚举类型`。

## 枚举类型的声明与枚举变量声明

```csharp
namespace cad
{
    //声明Weather枚举类型
    public enum Weather 
    {
        rain,
        snow,
        sun
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明Weather类型枚举变量
            Weather weather = (Weather)0;//将rain对应常量的别名赋值给变量
            //打印常量0别名
            Console.WriteLine(weather);//rain
            Weather sunWeather = Weather.sun;//采用Weather.别名方式赋值
            //打印常量2别名
            Console.WriteLine(sunWeather);//sun
        }
    }
}
namespace study
{
    //声明枚举类型QQState
    public enum QQState 
    {
        OnLine,
        //对应常量0,OnLine为常量0的别名
        OffLine,//对应常量1
        Leave,//对应常量2
        Busy,//对应常量3
        QMe,//对应常量4
    }
    //枚举变量也可以是中文
    public enum Sex {男,女 }
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明QQstate枚举变量并赋值。
            QQState state = QQState.Busy;
            Console.WriteLine(state);
            //输出Busy常量名
        }
    }
}
```

## 枚举类型的转换

### `enum`与`Int`转换

因枚举是一组带名字的常量组成的集合，在内存中默认存储为Int型，可以跟Int互相转换（相兼容）。当转换一个枚举中不存的的值时，不会抛异常，而是将数字显示出来。

```csharp
namespace study
{
    //声明枚举类型QQState
    public enum QQState 
    {
        OnLine,
        //对应常量0,OnLine为常量0的别名
        OffLine,//对应常量1
        Leave,//对应常量2
        Busy,//对应常量3
        QMe,//对应常量4
    }
    public enum Sex {男,女 }
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明枚举变量并赋值。
            QQState state = QQState.Busy;
            //将枚举类型转为Int型
            int numState = (int)state;
            Console.WriteLine(numState);//3

            //将Int 2 转为枚举 2
            int num = 2;
            QQState leaState = (QQState)num;//使用强转语法
            Console.WriteLine(leaState);//Leave
        }
    }
}
```

### enum与`string`转换

所有的类型都可以调用`ToString()`转化为`string`类型。

将字符串数字或文本转换为枚举类型，需要调用调用`Enum`类的`Parse`方法，如果转换的字符串是数字，枚举中没有也不会抛异常，若是文本，枚举中没有则会抛异常。

`Enum.Parse()`方法返回一个`object`类型，需要进行里氏转换。

```csharp
QQState onState = QQState.OnLine;
//string strOnLine = Convert.ToString(onState);
//可以调用Convert类中的ToString方法

//调用数据类型中ToString方法
string strOnLine = onState.ToString();
Console.WriteLine(strOnLine == "OnLine");//true
string strOnLine = "0";
//调用Enum对象的Parse方法，将数字字符串或枚举字符串转换为枚举类型
QQState onLine = (QQState)Enum.Parse(typeof(QQState), strOnLine);
Console.WriteLine(onLine == QQState.OnLine);//True
```

:arrow_down_small:转换练习

提示用户选择一个在线状态，接受并转换为枚举类型，再次打印到控制台中。

```csharp
Console.WriteLine("请输入在线状态，0---OnLine,1--OffLine," +
    "2--Leave,3--Busy,4--Qme");
string strState = Console.ReadLine();
switch (strState)
{
    case "0":
    case "1":
    case "3":
    case "2":
    case "4":
        QQState state = (QQState)Enum.Parse(typeof(QQState), strState);
        Console.WriteLine("你输入的状态是{0}", state);
        break;
}
```

# 类型转换

## 类型兼容

### 隐式类型转换

要求转换的变量类型兼容，且是小类型转大类型，如Int转double.【因为double类型变量可赋值整数】。

:one:如果一个操作数是`double`类型，则表达式值自动转换为`double`类型。

```csharp
int a = 35; 
double b = 1.2222;
Console.WriteLine(a*b);//42.777
int a = 35;
int b = 1;
double num = a * b * 1.000;
Console.WriteLine(num);//double类型，输出35
Console.WriteLine("{0:0.00}",num);//保留两位小数输出35.00
```

:two:将整数赋值给`double`类型，整数赋值给`float`类型，或者将`float`类型赋值给`double`类型，会进行隐式转换。

### 显示类型转换

类型兼容，可强制进行类型转换。语法：在括弧中写入要转换的类型。

1. `double`与`int`类型兼容
2. `int`与`enum`类型兼容，详见枚举章节

:one:`double`类型转`Int`类型.

```csharp
 double a = 2.000;
 int b = (int)a;//强制将小数2.000转换为整数2，a仍为double类型
 Console.WriteLine(b);//2
```

:two:`Int`类型转`double`类型.

```csharp
int num = 3;//int 类型
double doNum = (double)num;
Console.WriteLine("{0:0.00}",doNum);//3.00
```

## 类型不兼容

### Convert.To...类型转换

类型不兼容，如`string value`可通过Convert工厂进行转换。

1. `Convert.ToInt32()`:将指定值转化为整数。
2. `Convert.ToDouble()`:将指定值转换为小数。
3. `Convert.ToString()`：一切类型都可以转换为string类型

```csharp
string str = "123";
double num = Convert.ToDouble(str);
Console.WriteLine("{0:0.00}",num);//123.00
```

让用户输入语文，数学，英文三科分数，并将名字，总分，平均分打印出来。

```csharp
Console.WriteLine("请输入你的姓名");
string name = Console.ReadLine();//记录用户姓名
Console.WriteLine("请输入你的语文成绩");
double chinese = Convert.ToDouble(Console.ReadLine());//记录语文成绩
Console.WriteLine("请输入你的数学成绩");
double math = Convert.ToDouble(Console.ReadLine());//记录数学成绩
Console.WriteLine("请输入你的英语成绩");
double english = Convert.ToDouble(Console.ReadLine());//记录英语成绩
double num = chinese + math + english;//总分
double ave = num / 3;//平均分
Console.WriteLine("{0}，你的总分是{1},你的平均分是{2}",name,num,ave);
```

进一步判断用户输入的字符串是否能传唤为数字，封装成一个方法。

```csharp
static void Main(string[] args)
{
    //类型不兼容
    Console.WriteLine("请输入你的数学成绩");
    double math = InputScore(Console.ReadLine());
    Console.WriteLine("请输入你的语文成绩");
    double chinese = InputScore(Console.ReadLine());
    Console.WriteLine("请输入你的英语成绩");
    double english = InputScore(Console.ReadLine());
    int sum = (int)(math + chinese + english);
    double avg = sum / 3;
    Console.WriteLine("总分数{0}，平均分是{1}",sum,avg);
}
/// <summary>
/// 将用户输入的数字文本转换为数字
/// </summary>
/// <param name="str">数字型文本</param>
/// <returns>返回一个double类型的数字</returns>
public static double InputScore(string str) 
{
    while (true)
    {
        try
        {
            double num = Convert.ToDouble(str);
            return num;//转换成功退出
        }
        catch 
        {//程序错误跳到此处执行
            Console.WriteLine("输入非法值，请重新输入");
            str = Console.ReadLine();
        }
    }
}
```

### Parse( )方法

1. `int.Parse(string value)`方法将数字字符串转化为`int`类型
2. `double.Parse(string value)`方法将字数字符串转换为`double`类型
3. `Enum.Parse(type EnumType,string value)`方法将枚举常数名称或数字字符串转化为枚举类型，返回`object`。

```csharp
int num = int.Parse("123");
Console.WriteLine(num);//123
```

使用`convert.ToInt32( )`本质上调用的是`Int.Parse( )`。

### TryParse( )方法

1. `int.TryParse(string value,out int result )`接受两个参数，参数1，要转换的字符串，参数2为多余返回参数。如果方法正常运行，则方法返回布尔值True，参数2接收转换后的值，否则返回`false`,`num`赋值为0.
2. `double.TryParse()`
3. `Enum.TryParse()`，返回`object`,详见枚举。

```csharp
int num;
bool b = int.TryParse("123", out num);
Console.WriteLine("b = {0}，num = {1}", b, num);
//b = True，num = 123
```

# 异常捕获

异常：程序没有编译错误，但在运行过程中，由于某些原因导致程序不能正常运行。为了避免这些错误，我们要经常用`try-catch`进行异常捕获。哪来代码容易出现异常，就在在`try{}`里面。

```csharp
try
{
    //可能出现异常的代码
}
catch
{
    //出现异常后执行此处代码
}
```

如果`try`中代码没有出现异常，则不会执行`catch`中的代码；如果`try`中出现异常，则出现异常后面的语句都不会执行，而是直接跳转到`catch`中执行代码。

例_用户输入某个数字，返回数字的2倍。

```csharp
do 
{
    Console.WriteLine("请输入一个数字");
    try 
    {
        //可能出现异常的代码
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num * 2);
        break;
        //退出当前循环
    }
    catch 
    { //出现异常后转到此处执行代码
        Console.WriteLine("输入非法数字，请重新输入");

    }
} 
while (true);
```

:red_circle:`try-catch`之间不能有其他代码。

# 条件语句

## if语句

if语句中的条件一般是关系表达式，返回一个布尔值。条件成立，表达式值为true，则执行相关代码。

```csharp
//if语句，只能判断一种情况
if(条件){
    //条件成立则执行括弧内代码，不成立跳过if语句
}


// if else语句，判断两种情况
if(条件)
{
    //条件成立则执行括弧内代码，执行完成后，跳出if-else语句
}else
{
    //条件不成立不会执行if括弧中的语句，会执行else的代码    
}


// if  else-if 语句:用来处理多条件，区间性的判断
if(条件)
{
    //条件成立则执行括弧内代码，执行完成后，跳出if-else if结构
}
else if(条件)
{      
    //如果if中的条件不成立，则向下依次执行else if，
    //若条件成立则执行，然后跳出if-else if结构。
    //不成立则继续向下执行代码
}
//...多个else if语句
else
{
    //条件都不成立，执行else中的代码
}
```

:one:如果用户输入用户名为`admin`，密码为`mypass`,则提示登录成功。

```csharp
Console.WriteLine("请输入你的用户名");
string name = Console.ReadLine();
Console.WriteLine("请输入你的密码");
string password = Console.ReadLine();
bool b = (name == "admin") && (password == "mypass");//逻辑与构成的逻辑表达式
if (b) 
{
    Console.WriteLine("登录成功");
}
```

:two:年龄大于等于23岁，打印到了结婚年龄。

```csharp
 Console.WriteLine("请输入你的年龄？");
 int age = Convert.ToInt32 (Console.ReadLine());
 if (age >= 23)
 {		//条件成立执行if中的代码，完成后跳出if-else语句
     Console.WriteLine("你到了结婚年龄");
 }
 else
 {	//条件不成立执行else中的语句
     Console.WriteLine("未到结婚年龄");   
 }
```

:three:学员结业成绩测评：

| 成绩        | 评测 |
| ----------- | ---- |
| >=90        | A    |
| 90>成绩>=80 | B    |
| 80>成绩>=70 | C    |
| 70>成绩>=60 | D    |
| <60         | E    |

```c#
//if-else语句嵌套
 if (score >= 90)
 {
     Console.WriteLine("A");
 }
 else 
 {
     if (score >= 80)
     {
         Console.WriteLine("B");
     }
     else {
         if (score >= 70)
         {
             Console.WriteLine("C");
         }
         else {
             if (score >= 60)
             {
                 Console.WriteLine("D");
             }
             else { 
                 Console.WriteLine("E");
             }
         }
     }
 }
```

`if else-if语句`：结构清晰，适合**多条件，区间性**判断。

```csharp
 Console.WriteLine("请输入你的成绩");
 int score = Convert.ToInt32(Console.ReadLine());
 if (score >= 90)
 {//若条件成立，if中的代码，完成后退出if- else if 语句
     Console.WriteLine("A");
 }
 else if (score >= 80)
 {
     // 若if中条件不成立，则向下判断else-if中的条件，
     //满足则执行其中的代码，然后退出if-elseif语句
     Console.WriteLine("B");
 }
 else if (score >= 70)
 {
     Console.WriteLine("C");
 }
 else if (score >= 60)
 {
     Console.WriteLine("D");
 }
 else {
     Console.WriteLine("E");
 }
```

:four:输入三个数字比较大小，不考虑相等

```csharp
/*
*if(数字1>数字2且数字1>数字3)
*else if (数字2>数字1 && 数字2>数字3)
*else,都不符合条件，则数字3大
*/
Console.WriteLine("请输入第一个数字");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("请输入第二个数字");
 int num2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("请输入第三个数字");
 int num3 = Convert.ToInt32(Console.ReadLine());
 // 数字1>数字2且 数字1>数字3，则数1最大
 if (num1 > num2 && num1 > num3)
 {
     Console.WriteLine("数字{0}最大", num1);
 }
 // 数字2>数字1且 数字2>数字3，则数2最大
 else if (num2 > num1 && num2 > num3)
 {
     Console.WriteLine("数字{0}最大", num2);
 }
 // 数字3>数字1且 数字3>数字2，则数3最大
 else
 {
     Console.WriteLine("数字{0}最大",num3);
 }
/*先比较数字1与数字2，
 *若数字1大则，用数字1与数字3进行比较
 */
Console.WriteLine("请输入第一个数字");
int numOne = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第二个数字");
int numTwo = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第三个数字");
int numThr = int.Parse(Console.ReadLine());
if (numOne > numTwo)
{//数字1大于数字2，比较数字1与数字3
    if (numOne > numThr)
    {
        Console.WriteLine("最大的数字是{0}", numOne);
    }
    else
    {
        Console.WriteLine("最大的数字是{0}", numThr);
    }
}//外层if
else //数字1实际小于数字2
//比较数字2与数字3
{
    if (numTwo > numThr)
    {
        Console.WriteLine("最大的数字是{0}", numTwo);
    }
    else 
    {
        Console.WriteLine("最大的数字是{0}",numThr);
    }
}
```

## switch-case

用来处理`多条件`，`定值`判断。

```csharp
swicth(变量或表达式的值)
{
    case 值1 :
        要执行的代码;
        break;
    case 值2 ：
        要执行的代码;
        break;
    case 值3：
        要执行的代码;
        break;
    ...
    default：
        要执行的代码;
        break;
}

//若连续两处执行代码相同可使用简写
swicth(变量或表达式的值)
{
    case 值1
    case 值2 ：
        要执行的代码;
        break;   
    ...
}
```

`switch-case`执行过程：

1. 首先计算`switch`括弧内的变量或表达式的值

2. 用括弧内的值与case后面的值进行匹配，如果匹配成功，则执行相关`case`后面的语句，执行到`break`后跳出`switch-case`语句。

3. 如果都不匹配，则不执行`switch-case`中的语句（无`default`语句）；若存在`default`语句，则执行此处代码，然后跳出循环。

   :red_circle:`switch括弧`内的值类型要求与`case`中的值类型一致。

:arrow_down_small:`switch-case`语句练习：

:one:绩效评定，A级员工转正工资涨500，B级涨200元，C级工资不变，D级工资降200元，E级降500元。设实习工资5000元，请输入员工评级，显示该员工工资。

```csharp
int salary = 5000;
bool b = true; 
// 同来判断是否打印转正工资或提示用户输入正确等级
Console.WriteLine("请输入评定等级");
string str = Console.ReadLine();
switch (str) //用户输入的变量与case值进行匹配
{
    case "A": 
        alary += 500; //复合赋值运算符
        break;
    case "B": 
        salary += 200;
        break;
    case "C": 
        break;
    case "D": 
        salary -= 200;
        break;
    case "E":
        salary -= 500;
        break;
    default : 
        Console.WriteLine("请输入正确等级");
        b = false;
        break;
}
if (b)
{
    Console.WriteLine("转正工资{0}", salary);
}
```

:two:将`多条件区间判断转化`为`多条件定值`判断。

```csharp
 Console.WriteLine("请输入你的成绩");
 int score = Convert.ToInt32(Console.ReadLine());
 switch (score/10) //多条件区间判断转化为定值
 {
     case 10://case10要执行的代码需与case9一致，才可省略
     case 9 :
         Console.WriteLine("A级");
         break;
     case 8://注意此处值类型应与switch()内的值类型相同
         Console.WriteLine("B级");
         break;
     case 7:
         Console.WriteLine("C级");
         break;
     case 6:
         Console.WriteLine("D级");
         break;
     default:
         Console.WriteLine("E级");
         break;
 }
```

:four:请用户输入年份，再输入月份，输出该月的天数（注意2月与平年闰年有关）。

```csharp
 try //处理年份非法输入
 {
     Console.WriteLine("请输入年份");
     int year = Convert.ToInt32(Console.ReadLine());
     try//处理含字符的月份
     {
         Console.WriteLine("请输入月份");
         int month = Convert.ToInt32(Console.ReadLine());
         if (month >= 1 && month <= 12)//判断月份
         {
             switch (month)
             {
                 case 1:
                 case 3:
                 case 5:
                 case 7:
                 case 8:
                 case 10:
                 case 12:
                     Console.WriteLine("{0}年{1}月共31天", year, month);
                     break;
                 case 2:
                     if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                     //整除则余数等于0
                     {
                         Console.WriteLine("{0}年{1}月共29天", year, month);
                     }
                     else
                     {
                         Console.WriteLine("{0}年{1}月共28天", year, month);
                     }
                     break;
                 default://将4，6，9，11月
                     Console.WriteLine("{0}年{1}月共30天", year, month);
                     break;
             }
         }
         else //非法月份处理
         {
             Console.WriteLine("请输入正确月份，程序退出");
         }
     }//第二层try结束
     catch 
     {
         Console.WriteLine("请输入正确月份");
     }
 }//第一层try结束
 catch 
 {
     Console.WriteLine("请输入正确年份");
 }
```

## 三元表达式

`if-else`的简化写法。

```csharp
表达式1 ? 表达式2 ： 表达式3
 int sum = 2 > 1 ? 1 : 2;
```

表达式1一般为一个关系表达式，值为true，则`三元表达式的值` =` 表达式2的值`，为false，`三元表达式的值` = `表达式3的值`。

表达式2的值类型需要与表达式3的值类型相同，且与三元表达式的值类型相同。

:one:判断数字大小

```csharp
Console.WriteLine("请输入一个数字");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("请输入另一个数字");
int numTwo = Convert.ToInt32(Console.ReadLine());

int bigNum = numOne > numTwo ? numOne : numTwo;
//数字1大于数字2，则返回数字1，否则返回数字2

Console.WriteLine(bigNum);
```

# 循环语句

## while循环

```csharp
while(循环条件)
{
    循环体
}
```

* `while`循环会先判断循环条件（循环条件会返回一个布尔值），若为`true`,则执行循环体代码；
* 继续判断循环条件，若符合继续执行循环体条件，直到循环条件为`false`时退出循环。

:red_circle:若条件一直成立，则称该循环为`死循环`。

```csharp
int i = 0;
while(i < 2)
{
    循环体
}
```

`while`循环中，一般总会有一行代码，能够改变循环条件，使循环条件在某一时刻不在成立，从而退出循环。

```csharp
//向控制台打印十遍语句
int i = 0;//循环变量
while (i< 10)//循环条件i<10
{ 
    Console.WriteLine("一定会胜利");//循环体
    i++;//使循环条件某时刻为false
}
```

## break关键字

break可以跳出switch-case循环，也可以跳出循环（仅跳出当前循环）。

break语句通常与if语句连用。

:one:要求用户输入用户名`admin`和密码`888888`，只要一个不正确，要求重复输入。

```csharp
//方法1
string name = "", password = "";
//提前声明两个变量，扩大变量作用域
while (true)//一个死循环
{
    Console.WriteLine("请输入用户名");
    name = Console.ReadLine();
    Console.WriteLine("请输入密码");
    password = Console.ReadLine();
    if (name == "admin" && password == "888888")
    {
        Console.WriteLine("用户名及密码正确，登录成功");
        break;//跳出当前循环
    }
    else
    {
        Console.WriteLine("用户名或密码错误，请重新输入");
    }
}

//方法2

string name = "", password = "";
while (name != "admin" || password != "888888") 
    //用户名和密码正确时跳出循环
{
    if (name == "") 
    {
        Console.WriteLine("请输入用户名");
        name = Console.ReadLine();
        Console.WriteLine("请输入密码");
        password = Console.ReadLine();
    }
    else
    {
        //此处代码可以封装到一个方法里面
        Console.WriteLine("用户名密码错误，请重新输入");
        Console.WriteLine("请输入用户名");
        name = Console.ReadLine();
        Console.WriteLine("请输入密码");
        password = Console.ReadLine();
    }
}
Console.WriteLine("登录成功");
```

:two:输入班级人数，依次输入学员成绩，计算班级学员平均成绩和总成绩。

```csharp
  int sum = 0, i = 1,j=0; //定义总量以及循环变量
  bool b = false;//作为判断条件使用
  Console.WriteLine("请输入班级人数");
  try //输入人数判断
  {
      //错误后面代码不再执行
      j = Convert.ToInt32(Console.ReadLine());
      while (i <= j)
      {
          try
          {
              Console.WriteLine("请输入第{0}学员成绩", i);
              int score = Convert.ToInt32(Console.ReadLine());
              sum += score;
              i++;//循环变量自增
          }
          catch
          {
              b = true;
              break;
          }
      }//while结束括弧
      if (b)
      {
          Console.WriteLine("请正确输入学员成绩，程序退出");
      }
      else
      {
          Console.WriteLine("全班总成绩{0},平均成绩{1}", sum, sum / j);
      }

  }
  catch 
  {
      Console.WriteLine("程序退出，请输入正确人数");
  }
```

:three:老师讲题，询问学生会不会，若会直接放学，不会则继续讲解，直到讲10次仍不会直接放学。

```csharp
int i = 1;//循环条件
string answer = "";
bool b = false;//判断条件
while (i <= 10) 
{
    Console.WriteLine("这道题你会做了吗");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("放学");
        break;//跳出循环
    }
    else
    {
        if (i == 10)
        {//第十次仍不会直接放学
            b = true;
            break;
        }
        else 
        {//1-9次回答否输出正在讲解
            Console.WriteLine("讲解中...");
        }
    }
    i++;//循环变量自增
}//while循环结束
if (b) 
{
    Console.WriteLine("今天就到这里，回去好好复习吧");
}
   int i = 1;
   string answer = "";
   bool b = true;//判断条件
   Console.WriteLine("这道题你会做了吗？Yes/No");
   answer = Console.ReadLine();
   while (answer != "Yes") 
   {//while开始
       Console.WriteLine("讲解中(第{0}次)...",i);
       Console.WriteLine("会了吗");
       answer = Console.ReadLine();
     if (i ==10 && answer != "Yes")//第10次仍然不会
       {
           Console.WriteLine("回去好好复习,放学");
           b = false;
           break;
       }
       i++;
   }//while结束
   if (b) //回答会了在此处放学
   {
       Console.WriteLine("放学");
   }
```

:four:2006年培养学员8000人，增长率25%，按此增长速度，哪一年培养总人数达到20万人？

```csharp
double student = 8000,i=0;
while (student <=200000) 
{
    student *= 1.25;
    i++;
}
Console.WriteLine("在{0}年，人数首次大于20万人,共{1:0.00}",2006+i,student/10000);
//在2021年，人数首次大于20万人,共22.74
```

:five:提示用户输入yes/y，如果不是，重复提示，直到输入正确。

```csharp
Console.WriteLine("请输入yes/y");
string answer = Console.ReadLine();
while (true)
{
    if (answer == "yes" || answer == "y")
    {
        Console.WriteLine("输入正确，程序退出");
        break;
    }
    else 
    {
        Console.WriteLine("请重新输入yes/y");
        answer = Console.ReadLine();
    }
}
```

:six:提示用户输入用户名和密码，要求用户名为admin，密码为888888，只要用户名和密码错误要求重新输入，不能超过3次。

```csharp
int i = 1;
string name = "", password = "";
bool b = name != "admin" || password != "888888";
//false || false时，b为false,即输入正确的用户名和密码时b为false
while (i<= 3 && b) 
{
    i++;
    Console.WriteLine("请输入你的用户名");
    name = Console.ReadLine();
    Console.WriteLine("请输入你的密码");
    password = Console.ReadLine();
}
if (!b)//用户名和密码正确
{
    Console.WriteLine("登录成功");
}
else //超过3次仍未成功
{
    Console.WriteLine("输入超过3次，程序退出");
}
```

## do-while循环

`do-while`循环会先执行一次循环体，然后再去判断`while`中的条件，若为`true`,则继续执行，直到条件为`false`时结束。

:red_circle:与`while`循环的区别：`while`循环会先判断循环条件，若为true，才执行循环体，`do-while`则相反，至少会执行一次循环体。

```csharp
do
{
    //循环体
}while(循环条件);
```

:one:小兰唱歌，直到老师满意为止。

```csharp
string answer = "";//声明赋值为空
bool b = true;//用来条件判断
do//先去执行一次循环体
{
    if (b)
    {//第一次询问
        b = false;
        Console.WriteLine("唱的可以吗Yes/No");
        answer = Console.ReadLine();
    }
    else
    {//后面的询问
        Console.WriteLine("复唱中...\n");
        Console.WriteLine("这次可以吗");
        answer = Console.ReadLine();
    }
}
while (answer != "Yes");//循环体执行完成后判断循环条件
Console.WriteLine("可以，放学");
```

:two:要求用户输入用户名`admin`和密码`888888`，只要一个不正确，要求重复输入。

```csharp
string name = "", password = "";
bool b = true;
do
{
    if (b)
    {
        //待封装
        Console.WriteLine("\n请输入你的用户名");
        name = Console.ReadLine();
        Console.WriteLine("\n请输入你的用户密码");
        password = Console.ReadLine();
        b = false;
    }
    else
    {
        Console.WriteLine("用户名或密码错误，请重新输入");
        Console.WriteLine("\n请输入你的用户名");
        name = Console.ReadLine();
        Console.WriteLine("\n请输入你的用户密码");
        password = Console.ReadLine();
    }
}
while (name != "admin" || password != "888888");//或关系
Console.WriteLine("用户名及密码正确，登录成功");
```

:three:不断要求用户输入学生姓名，按q结束。

```csharp
 string name = "";
 do
 {
     Console.WriteLine("请输入学生姓名,按q结束");
     name = Console.ReadLine();
     if (name == "q")
     {
         Console.WriteLine("程序退出");
     }
     else 
     {
         Console.WriteLine("你输入的名称是{0}",name);
     }
 } while (name != "q");//输入q时条件返回false,退出循环
```

:four:不断要求用户输入一个数字，打印该数字的2倍，当用户输入`q`时程序退出。

```csharp
 string strNum = "";
 do
 {
     Console.WriteLine("请输入一个数字，按q退出");
     strNum = Console.ReadLine();
     try//异常处理
     {
         double num = Convert.ToDouble(strNum);//输入可以转成数字的字符串在此处处理
         num *= 2;
         Console.WriteLine("{0}的2倍是{1}", strNum, num);//打印输入的2倍
     }
     catch {
         if (strNum == "q")
         {
             Console.WriteLine("程序退出");
         }
         else
         {
             Console.WriteLine("数字应不含字符，请重新输入\n");
         }
     }
   
 }
 while (strNum != "q");//不等于q（逻辑true）时程序继续执行
```

:five:不断要求用户输入数字（假定都是正整数），当用户输入`End`时，显示已输入的最大数字。

```csharp
  string strNum = "";
  int bigNum = 0, smallNum = 0;
  do
  {
      Console.WriteLine("请输入一个正整数，End退出");
      strNum = Console.ReadLine();
      try //异常处理
      {//数字型字符串转化为int型，并赋值给大数
          smallNum = Convert.ToInt32(strNum);
          if (bigNum >= smallNum)
          {

          }
          else
          {
              bigNum = smallNum;
          }
      }
      catch 
      {
          if (strNum == "End") //输入End正确退出
          {
              Console.WriteLine("程序退出，将返回最大数值\n");
          }
          else 
          {
              Console.WriteLine("输入错误字符，将返回已输入最大数值，或默认数值0");
              strNum = "End";//终止循环
          }
      }
  }
  while (strNum != "End");
  Console.WriteLine("最大数字为{0}",bigNum);
```

## for循环

已知循环次数，推荐用`for`循环。

:bookmark:快捷键：写上`for`,按`table`键。逆向for循环，写入`forr`，按`table`键

```csharp
for(表达式1，表达式2，表达式3)
{
    循环体
}
表达式1：声明循环变量，记录循环次数 int i =0
表达式2：循环条件 i<10
表达式3：改变循环条件，i++
//示意代码
  for (int i = 0; i<10;i++) 
  {
      Console.WriteLine("欢迎来到C#");
  }
```

执行过程：

1. 先执行变量声明
2. 判断循环条件
3. 执行循环体
4. 执行表达式3(自增或自减)
5. 判断循环条件，`true`则执行循环体，`false`退出循环。

### for循环练习

:one:打印1\~10，10\~1。

```csharp
  for (int i = 1; i <=10 ; i++) 
  {
      Console.WriteLine(i);//打印1~10
      //Console.WriteLine(11-i);打印10~1另一种写法
  }
//打印10~1
 for (int i =10; i >= 1; i--)
 {
     Console.WriteLine(i);
 }
```

:two:1~100所有整数和，所有偶数和，所有奇数和

```csharp
 int sum = 0, doubleSum = 0, angelSum = 0;
 for (int i = 1; i <= 100; i++)
 {
     sum += i;//所有整数和
     if (i % 2 == 0)
     {
         //所有偶数和
         doubleSum += i;
     }
     else 
     {
         angelSum += i;
     }
 }//for循环结束
 Console.WriteLine("1~100整数和为{0}，偶数和为{1}，奇数和为{2}",sum,doubleSum,angelSum);
//偶数另一种写法
 int sum = 0;
 for (int i = 2; i <= 100; i += 2)
 {
     sum += i;
 }
```

:three:找出100~999所有水仙花数（百位的立方+十位的立方 + 个位的立方等于这个数）

```csharp
  int ge = 0, shi = 0, bai = 0, sum = 0;
  for (int i = 100; i <= 999; i++)
  {
      ge = i % 10;
      shi = i % 100 / 10;
      //模与乘除同等级
      bai = i / 100;
      sum = ge * ge * ge + shi * shi * shi + bai * bai * bai;
      //学习一下立方写法
      if (sum == i)
      {
          Console.WriteLine("水仙花数有{0}", i);
      }
  }
```

:four:当做一遍A，要循环N次B，则使用for循环嵌套。

```csharp
 for (int i = 1; i <=  9; i++)
 {
     for (int j = 1;  j <= 9;  j++)
     {
         Console.Write("{0}*{1}={2}\t",i,j,i*j);//console.write并不会独占一行
     }
     Console.WriteLine();//单独输出空行，console.write输出的内容会占满此行
 }
/*输出形式
1*1=1   1*2=2   1*3=3   1*4=4   1*5=5   1*6=6   1*7=7   1*8=8   1*9=9
2*1=2   2*2=4   2*3=6   2*4=8   2*5=10  2*6=12  2*7=14  2*8=16  2*9=18
3*1=3   3*2=6   3*3=9   3*4=12  3*5=15  3*6=18  3*7=21  3*8=24  3*9=27
4*1=4   4*2=8   4*3=12  4*4=16  4*5=20  4*6=24  4*7=28  4*8=32  4*9=36
5*1=5   5*2=10  5*3=15  5*4=20  5*5=25  5*6=30  5*7=35  5*8=40  5*9=45
6*1=6   6*2=12  6*3=18  6*4=24  6*5=30  6*6=36  6*7=42  6*8=48  6*9=54
7*1=7   7*2=14  7*3=21  7*4=28  7*5=35  7*6=42  7*7=49  7*8=56  7*9=63
8*1=8   8*2=16  8*3=24  8*4=32  8*5=40  8*6=48  8*7=56  8*8=64  8*9=72
9*1=9   9*2=18  9*3=27  9*4=36  9*5=45  9*6=54  9*7=63  9*8=72  9*9=81
*/
/*输出形式
1*1=1
2*1=2   2*2=4
3*1=3   3*2=6   3*3=9
4*1=4   4*2=8   4*3=12  4*4=16
5*1=5   5*2=10  5*3=15  5*4=20  5*5=25
6*1=6   6*2=12  6*3=18  6*4=24  6*5=30  6*6=36
7*1=7   7*2=14  7*3=21  7*4=28  7*5=35  7*6=42  7*7=49
8*1=8   8*2=16  8*3=24  8*4=32  8*5=40  8*6=48  8*7=56  8*8=64
9*1=9   9*2=18  9*3=27  9*4=36  9*5=45  9*6=54  9*7=63  9*8=72  9*9=81
*/
for (int i = 1; i <=  9; i++)
   {
       for (int j = 1;  j <= i;  j++)
       {
           Console.Write("{0}*{1}={2}\t",i,j,i*j);//console.write并不会独占一行
       }
       Console.WriteLine();//单独输出空行，console.write输出的内容会占满此行
   }
```

:five:输入一个数字，按照指定格式输出。

```csharp
/*指定格式
0+3=3
1+2=3
2+1=3
3+0=3
*/
int num = 0;
Console.WriteLine("请输入一个数字");
num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= num; i++)
{
    Console.WriteLine("{0}+{1}={2}",i,num-i,num);
}
```

:six:1~100整数相加，得到累加值大于20时，把循环变量i打印出来。（`1+2+3+4+5+6=21`）打印`6`

```csharp
int sum = 0;
for (int i = 1; i <=100; i++)
{
    sum += i;
    if (sum >= 20) 
    {
        Console.WriteLine("总和等于{0},i等于{1}",sum,i);
        break;//退出循环
    }
}
```

:seven:循环录入5个人的年龄并计算平均年龄，如果录入非法数字请停止循环并报错。

```csharp
 int sumAge = 0 ,age = 0;
 //存储总年龄，以及个人年龄
 bool b = true;//存储Int.TryParse返回的布尔值，用来进行条件判断
 for (int i = 1; i <= 5; i++)
 {
     Console.WriteLine("请输入第{0}个人的年龄",i);
     b = int.TryParse(Console.ReadLine(), out age);
     if (b && age >= 0 && age <= 100)
     {
         sumAge += age;
     }
     else if (b)//超出范围数字的入口
     {
         Console.WriteLine("输入超出范围的年龄，程序退出");
         b = false;
         //b若为超出范围的数字，手动赋值为false
         break;//退出循环
     }
     else//含字母数字的入口
     {
         Console.WriteLine("输入非法数字，程序退出");
         break;//退出循环
     }
 }//for循环结束
 if (b) 
 {
     Console.WriteLine("5人的平均年龄是{0}",sumAge/5);
 }
```

## foreach循环

> 意在循环数组中的每一项`item`。

```c#
//语法规范
foreach (var item in collection)
{
    //item 元素
    //collection集合
    //遍历集合中的每一项
}
```

:bookmark:示例

```csharp

int[] nums = { 1, 2, 4, 2, 4423, 23, 3, 32, 1, 23 };
foreach (int i in nums)
{
    Console.WriteLine(i);
}
```

## Continue关键字

> 条件符合时，跳出此次循环，继续下个循环，直到循环条件为`false`。

:one:用while与continue实现1~100之间除了被7整除之外的所有整数和。

```csharp
int sum = 0, i =1;//存储总和
while ( i <= 100 )
{
    if (i % 7 == 0)
    {
        i++;
        continue;//跳出此次循环，继续下个循环
        //后面代码不再执行
    }
    sum += i;
    i++;
}
Console.WriteLine("总和为{0}",sum);//4315
```

:two:找出100之内所有素数（能被1和它本身整除，`1`不是质数，最小的质数是`2`）

```csharp
//找出100之内的所有素数
//i%j，j是从2到i-1,i是2到100
for (int i = 2; i <=100; i++)
{
    bool b = true;//假设是质数
    for (int j = 2; j <= i-1; j++)
    {
        if (i % j == 0) 
        {
            b = false;//实际不是质数
            break;//退出当前循环
        }
    }
    if (b) { Console.WriteLine("{0}是质数",i); }
}
//此种方法，质数2未参与判断
```

# 结构

一次性声明多个不同类型的字段。

使用规范：

1. 声明结构类型
2. 创建结构实例
3. 给结构实例的成员赋值

```csharp
[public] struct 结构名
{
    //结构成员
    public 数据类型 _字段1；
    public 数据类型_字段2；
}
//字段可以存多个值
```

:one:声明结构类型

```csharp
  //声明一个Perosn结构
  public struct Person 
  {
      //成员
      public string _name;
      public int _age;
      public Sex _sex;
  }
  //声明Sex类型
  public enum Sex { 男, 女 }
```

:two:创建结构实例，并访问其成员

```csharp
 //创建Person实例
 Person zsPerson;
 //给zsPerson的成员赋值
 zsPerson._name = "张三";//string
 zsPerson._age = 15;//int
 zsPerson._sex = Sex.男;//枚举类型
```

------

:bookmark:练习

:one:定义一个`MyColor`结构,成员有`int`类型的`red,green,blue`，并创建一个实例表示红色。

```csharp
//声明一个Mycolor结构
public struct MyColor 
{
    public int _red;
    public int _green;
    public int _blue;
}

//创建一个实例mycolor
MyColor myColor;
//给其成员赋值
myColor._red = 255;
myColor._green = 0;
myColor._blue = 0;
```

与类不同的是， struct 传递属于值传递。 

# 数组

## 基本用法

一次性声明或存储多个相同类型的变量采用数组。

```csharp
数组类型[] 数组名 = new 数组类型[数组长度]
int[] arr = new int[10];
//在内存中开辟了10块空间，这些空间称为数组的元素，初始值为0
arr[3] = 10;
//根据索引给元素赋值
通过循环给数组赋值 arr.length表示数组的长度，int值
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}
//string[]
string[] strArr = new string[10];
//默认为null，null != ""，没有在内存开空间
//bool[]
 bool[]  boArr = new bool[4];
//默认为false

//其他声明方式
int[] arr = { 1, 2, 3, 4 };//声明数组并赋值
int[] arr = new int[] { 1, 2 };//了解
```

:bookmark:练习

:one:从一个整数数组中取出最大的整数，最小的整数，总和以及平均值。

```csharp
int[] arr = { 1, 3, 4, 5, 6 };
int sum= 0, averge = 0,bigNum = 0,smallNum = arr[2];
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];//sum累加
    //假定最大值与数组每个元素进行比较，
    //若最大值<=元素时成立，则将元素值赋值给bigNum
    if (bigNum <= arr[i])
    {
        bigNum = arr[i];
    }
    //假定最小值与数组每个元素进行比较
    if (smallNum >= arr[i]) 
    {
        smallNum = arr[i];
    }
}//循环结束
averge = sum / arr.Length;
Console.WriteLine("合计{0},平均值{1},最大数{2},最小数{3}",sum,averge,bigNum,smallNum);
```

:two:把数组的所有元素用字符串表示，用`|`分隔。

```csharp
 //定义一个string数组
 string[] strName = { "老杨","老苏","老邹","老虎","老牛","老王","小马" };
 string mergeName = null;//未分配空间
 for (int i = 0;i<strName.Length; i++) 
 {
     //循环合并
     mergeName += //复合赋值运算符
         i < strName.Length - 1 ? strName[i] + "|" :strName[i];
 }
 Console.WriteLine(mergeName);
```

:three:把一个整数数组进行如下处理：如果元素时正数，元素值+1，如果时负数，元素值-1元素值为0保持不变

```csharp
int[] intArr = { 1, 3, 4, 5, 0, -22, -5, -23 };
for(int i = 0;i<intArr.Length; i++) 
{
    if (intArr[i] >= 1)
    {
        //正数元素值+1
        intArr[i]++;
    }
    else if (intArr[i] < 0)
    {
        //小于0元素值-1
        --intArr[i];
    }
    Console.WriteLine(intArr[i]);//打印数组元素
}//for循环遍历结束
```

:four:数组元素顺序进行反转。`{"我","是","好人"}`反转成`{"好人","是","我"}`。

```csharp
 string[] strArr = { "我", "是", "好人" };
 string temp = null;
 for (int i = 0; i < strArr.Length/2; i++) 
 {
     //下标小的元素赋值给临时变量
     temp = strArr[i];
     strArr[i] = strArr[strArr.Length-1-i];
     //索引相互对应，如长度10的数组，0-9,1-8
     strArr[strArr.Length-1-i] = temp;
 }
 for (int i = 0; i < strArr.Length; i++) 
 {
     Console.WriteLine(strArr[i]);//依次打印数组元素
 }
```

## 冒泡排序

将数组中的元素按照从大到小或者从小到大的顺序进行排列。

```csharp
//冒泡排序
int[] numArr = { 1, 3, 2, 34, 15, 6, 7 };
for (int i = 0; i < numArr.Length - 1; i++)
{//把大数往后挪了numArr.Length-1趟
    for (int j = 0; j < numArr.Length - 1 - i; j++)
    //内部比较次数可变，为总循环次数-已循环次数，因大数已经置后
    {
        if (numArr[j] > numArr[j + 1])
        {
            //大值放到后面
            int temp = numArr[j];
            numArr[j] = numArr[j + 1];
            numArr[j + 1] = temp;
        }
    }
}
for (int i = 0; i < numArr.Length; i++)
{
    Console.WriteLine(numArr[i]);
}
```

数组中内置的排序函数:

```csharp
int[] numArr = { 1, 3, 2, 34, 15, 6, 7 };
Array.Sort(numArr);//sort针对数组进行升序排列
Array.Reverse(numArr);//对数组进行反转
```

# 程序调试

调试时机：

1. 写完程序后，想了解程序的执行过程
2. 程序并没有按照预想的方式执行

调试方法：

1. F11逐句调试
2. F10逐过程调试
3. 断点调试

## 单步调试

调试入口点在`main`函数里面，标记黄色表示即将被执行。

![img](assets/1737212693795-e1cf6196-1bc3-4ae4-941f-4d3684352bf6.png)

在执行过程中监视变量值与表达式。

![img](assets/1737213006784-bc2fabaa-79a8-4f37-8e1f-e32fe9f0b070.png)

## 断点调试

即程序在某节点停下来，然后进行逐句调试。



# 函数

## 简介

将一段功能性代码封装进行重用，可能有参数，也可能有返回值。

方法的功能一定要单一：如定义一个求取最大值方法，不能在里面添加求润年函数。

忌讳方法里面提示用户输入，因为`Conosle.WriteLine()`只有在控制台中存在，不能在其他地方使用。

```csharp
[public] static 返回值类型 方法名（[形参列表]）
{
    方法体;
}
//public 访问修饰符
//static 静态，关键字
//void代表不需要返回值
//方法名符合Pascal规范
//形参列表，可省略
```

:one:自定义一个比较数字大小的方法。

```csharp
 /// <summary>
 /// CompareNum方法用于比较两个数的大小，返回最大值
 /// </summary>
 /// <param name="a">int参数1</param>
 /// <param name="b">int参数2</param>
 /// <returns>返回最大值</returns>
 public static int CompareNum(int a, int b) 
 {//自定义方法应与Main函数处于平级关系
     int c = a >= b ? a : b;
     return c;
 }
```

在Main函数中调用方法：`类名.方法名()`

```csharp
//Main函数中调用方法
int num = Program.CompareNum(2, 3);//传递实参
Console.WriteLine(num);
```

:two:自定义一个不返回值的方法，并在`Main`函数中调用。

```csharp
/// <summary>
/// 一段封装好的歌曲函数
/// </summary>
public static void Sing() //用boid关键字声明 
{
    Console.WriteLine("艳阳天那么风光好");
    Console.WriteLine("红的花儿是绿的草");
    Console.WriteLine("乐乐呵呵向前跑");
    Console.WriteLine("踏遍青山人未老");
}
//在Main函数中调用
Program.Sing()
    
```

:red_circle:调用方法的时候，某些情况下可省略类名：如果自定义方法跟Main函数在同一个类中，类名可省略，直接写方法即可。

## return关键字

1. 在方法中返回要返回的值
2. 立即结束本次方法。

```csharp
static void Main(string[] args)
{
    while (true)
    {
        Console.WriteLine("while循环内输出");
        return;
    }
    Console.WriteLine("while循环外");//此处不会输出
}
//程序执行到return处会立即退出Main函数，while循环外的输出语句不会执行
```

## 方法调用

我们在Main函数中调用自定义函数，我们管Main函数叫`调用者`，自定义函数叫被`调用者`。

若`被调用者`想获得`调用者`中声明的变量:

:one:传参（形参与实参）

1. 形参：形式上的参数，要求调用方法时传递参数的类型与数量一致，与实参互不影响。
2. 二者都在内存内开辟空间。

:two:使用静态字段来模拟全局变量

若调用者想获得被调用者的值，需要被调用者有返回值。

```csharp
static void Main(string[] args)
{
    int number = 3;
    //调用方法
    int changeNum =  GetNumber(number);
    Console.WriteLine(changeNum); //8
    Console.WriteLine(number);//3
    //方法体参数声明的是局部变量，方法结束后就会销毁
}
//自定义方法
public static int GetNumber(int a) 
{
    return a += 5;   
}
```

## 方法简单练习

:one:写一个方法，判断年份是否为闰年。

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入一个年份");
    string year = Console.ReadLine();
    IsLeapYear(year);
}
public static void IsLeapYear(string year) 
{ 
    //适合使用try-catch
    int intYear = int.Parse(year);//转成int类型
    //闰年条件 被400整除 或 被4整除但不被100整除
    if (intYear % 400 == 0 || (intYear % 4 == 0 && intYear % 100 != 0))
    {
        Console.WriteLine("{0}是闰年", year);
    }
    else 
    {
        Console.WriteLine("{0}年不是闰年",year);
    }
}
```

:two:读取用户输入的内容，如果是整数，则返回，否则提示用户重新输入。

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入一个数字");
    string str = Console.ReadLine();
    ReadNum(str);
}
/// <summary>
/// 将用户输入的内容转化为数字，返回Int型数字
/// </summary>
/// <param name="str">参数为用户输入的字符串</param>
/// <returns>返回数字</returns>
public static int ReadNum(string str)
{
    bool b = false;
    do
    {
        b = int.TryParse(str, out int num);
        if (!b)//转换失败入口
        {
            Console.WriteLine("请重新输入一个文本型数字");
            str = Console.ReadLine();
        }
    } while (!b);//转换失败执行，成功则退出循环
    return num;
}
```

:three:允许用户输入Y/N，若不是提示重新输入。

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入Y/N");
    string input = Console.ReadLine();
    //调用方法
    string str=Repeat(input);
    Console.WriteLine(str);
}
public static string Repeat(string str) 
{
    bool b = str == "Y" || str == "N";
    //输入Y或者N则b为true
    while (!b) //输入非法字符入口
    {
        Console.WriteLine("输入非法字符，请重新输入");
        str = Console.ReadLine();
        b = str == "Y" || str == "N";
        //布尔变量重新赋值
    }
    //输入正确
    return str;
}
```

:four:计算输入数组的和。

```csharp
static void Main(string[] args)
{
    int[] arr = { 1, 3, 5, 7, 8 };
    int arrSum =SumArr(arr);
    Console.WriteLine(arrSum);
}
/// <summary>
/// 求数组的和
/// </summary>
/// <param name="arr">传入需要求和的数组</param>
/// <returns>返回总和值</returns>
public static int SumArr(int[] arr) 
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        sum += arr[i];
    }
    return sum;
}
```

## 方法的高级参数

### out参数

如果在一个方法中，返回多个相同类型的值的时候，可以考虑返回一个数组；

如果返回多个不同类型的值的时候，考虑使用out参数。

out参数侧重于在一个方法中返回多个不同类型的值（也可以返回多个相同类型的值）,允许参数通过引用传递，可以不预先初始化变量。

```csharp
public static int[] GetMaxMinSumAvg(int[] arr)
{
    //num[0]是最大值，num[1]是最小值,num[2]是和，num[3]是平均值
    int[] num = new int[4];
    num[0] = arr[0];
    num[1] = arr[0];
    for (int i = 0; i < arr.Length; i++) 
    {
        //假定最大值小于某个元素，则将该元素赋值给num[0]
        if (num[0] < arr[i]) 
        { 
            num[0] = arr[i];
        }
        //假定最小值大于某个元素，则将该元素赋值给最小值
        if (num[1] > arr[i]) 
        {
            num[1] = arr[i];
        }
        num[2] += arr[i];//求和，num[2]默认为0
    }
    num[3] = num[2]/arr.Length;//求平均值
    return num;//返回数组
}
```

使用out返回多余参数。

```csharp
static void Main(string[] args)
{
    int[] arr = { 1, 3, 5, 7 ,-5};
    int max, min, sum, avg;//声明变量
    GetMaxMinSumAvg(arr, out max, out min, out sum, out avg);
    //变量在方法中赋值

    Console.WriteLine(max);
    Console.WriteLine(min);
    Console.WriteLine(sum);
}
/// <summary>
/// 求一个数组的最大值，最小值，和以及平均值
/// </summary>
/// <param name="nums">要求的数组</param>
/// <param name="max">多余返回的参数，最大值</param>
/// <param name="min">多余返回的参数，最小值</param>
/// <param name="sum">多余返回的参数，和</param>
/// <param name="avg">多余返回的参数，平均值</param>
public static void GetMaxMinSumAvg(int[] nums,out int max,
                                   out int min,out int sum,out int avg)
{
    //out参数要求内部必须赋值
    max = nums[0];
    min = nums[0];
    sum = 0;
    for (int i = 0; i < nums.Length; i++) 
    {
        if (nums[i] > max) 
        {
            max = nums[i];
        }
        if (nums[i] < min) 
        {
            min = nums[i];
        }
        sum += nums[i];
    }
    avg = sum/nums.Length;
}
```

:one:写一个方法，分别判断用户登录是否成功，并且返给用户一个登录结果`true`/`false`，还要返回一个具体的登录信息

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入用户名");
    string name = Console.ReadLine();
    Console.WriteLine("请输入用户密码");
    string password = Console.ReadLine();
    string information;
    //调用方法，
    bool b = IsLogin(name, password, out information);
    Console.WriteLine("登录信息——{0}",information);
}
/// <summary>
/// 判断用户是否登录成功
/// </summary>
/// <param name="name">用户名参数</param>
/// <param name="password">用户密码参数</param>
/// <param name="information">
/// 多余返回的信息，告知用户是否登录成功，或用户名密码的状态
/// </param>
/// <returns>默认返回登录状态</returns>
public static bool IsLogin(string name,string password,out string information) 
{
    if (name == "admin" && password == "888888")
    {
        information = "登录成功";
        return true;
    }
    else if (name == "admin")
    {
        information = "密码错误";
        return false;
    }
    else if (password == "888888")
    {
        information = "用户名错误";
        return false;
    }
    else 
    {
        information = "用户名与密码都错误";
        return false;
    }
}//方法结束
```

:two:模仿`int.TryParse()`函数。

```csharp
static void Main(string[] args)
{
    int num;
    Console.WriteLine("请输入一个数字型文本");
    string str = Console.ReadLine();
    bool b = ImitateTryParse(str, out num);
    Console.WriteLine(b);
    Console.WriteLine(num);
}

//模仿int.TryParse(string str,out int a)方法
public static bool ImitateTryParse(string s, out int num)
{
    try
    {
        num = int.Parse(s);
        return true;
    }
    catch
    {
        num = 0;
        return false;
    }
}
```

### ref参数

`ref`参数，指定参数按照引用传递。`ref`要求在方法外必须赋值。

```csharp
static void Main(string[] args)
{
    int money = 5000;
    Salary(ref money);
    Console.WriteLine(money使用方法交换两个int类型的变量。);//5500
    //方法结束后，实参值也做改变
}
public static void Salary(ref int money) 
{
    money += 500;
}
```

:one:使用方法交换两个`int`类型的变量。

```csharp
static void Main(string[] args)
{
    int a = 3;
    int b = 5;
    Change(ref a, ref b);
    Console.WriteLine(a);
    Console.WriteLine(b);
}

public static void Change(ref int a,ref int b) 
{
    a = b - a;
    b = b - a;
    a += b;
}
```

### params_可变参数数组

将实参列表中跟可变参数数组类型一致的变量当作数组元素去处理；

:red_circle:可变参数数组必须是在形参列表最后一个参数；

:red_circle:一个参数列表中只能存在一个可变参数数组。

```csharp
static void Main(string[] args)
{
    string name = "张三";
    int id = 2027;
    Test(name, id,99,100,90);
}
public static void Test(string name, int id,params int[] score) 
{
    int sum = 0;
    for (int i = 0; i < score.Length; i++) 
    {
        sum += score[i];
    }
    Console.WriteLine("{0},id是{1},总成绩是{2}",name,id,sum);
}
```

1. 求任意长度整数类型数组的最大值。

```csharp
static void Main(string[] args)
{
    int[] list = { 1, 2, 3, 4, 56, 7 };
    //Console.WriteLine(ArrMax(list));可以直接传递数组参数
    Console.WriteLine(ArrMax(8,9,1));
    //将实参列表中与可变参数数组类型一致的变量当作数组元素处理
}
//求任意长度整数类型数组的最大值
public static int ArrMax(params int[] arr) 
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > max) 
        {
            max = arr[i];
        }
    }
    return max;
}
```

## 方法的重载

重载指的是方法名称相同，但是参数不同（**方法返回值与重载没有关系**）。

参数不同：

1. 参数个数相同，但是类型不能相同；
2. 参数类型一样，但是个数不相同；

重载的作用是把功能类似的方法整合到一起，方便使用。

`Console.WriteLine()`方法也是重载而来：

![img](assets/1737979021783-cefab9a8-6727-4a37-be2c-232645495b51.png)

```csharp
static void Main(string[] args)
{
    //调用Connect方法，会有四种不同输入参数提示
    Connect(1, 3);
}
//构建重载方法
//整数类型，double类型相加，字符串连接
//类型1：两个int整数相加
public static int Connect(int a ,int b) 
{
    return a + b;
}
//类型2：两个double类型相加
public static double Connect(double a, double b) 
{
    return a + b;
}
//类型3：两个字符连接
public static string Connect(string a, string b) 
{
    return a + b;
}
//类型4：3个int相加
public static int Connect(int a,int b,int c) 
{ 
    return a + b + c;
}
```

## 方法的递归

方法自己调用自己。（找文件夹中所有文件）

## 综合练习

:one:提示用户输入两个数字，并计算两个数字之间所有整数之和

* 用户只能输入数字
* 要求第一个数字小于第二个数字

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入第一个数字");
    string strNumOne = Console.ReadLine();
    int numOne = Num(strNumOne);//若能转化为数字，则退出方法

    Console.WriteLine("请输入第二个数字");
    string strNumTwo = Console.ReadLine();
    int numTwo = Num(strNumTwo);//若能转化为数字，则退出方法
   //调用比较方法
   Judge(ref numOne, ref numTwo);//需要将改变后的值带出方法
    //求和
    int sum;
    SumNumber(numOne,numTwo,out sum);//使用out参数返回变量值
    Console.WriteLine(sum);
}

//文本数字转换为int型数字
public static int Num(string strNum) 
{
    while (true) 
    {
        bool b = int.TryParse(strNum, out int result);

        if (b)
        {
            return result;//返回转化后的数字
        }
        else 
        {
            Console.WriteLine("输入非法数字，请重新输入");
            strNum = Console.ReadLine();
        }
    } 
}//方法结束

//比较数字1与数字2
public static void Judge(ref int a, ref int b) 
{
    while (true) 
    {
        if (a >= b)
        {
            Console.WriteLine("要求第一个数字必须小于第二个数字");
            Console.WriteLine("请重新输入第一个数字");
            string s1 = Console.ReadLine();
            //调用转换方法
            a = Num(s1);
            Console.WriteLine("请重新输入第二个数字");
            string s2 = Console.ReadLine();
            b = Num(s2);
        }
        else
        {
            //符合题意退出比较方法
            return;
        }
    }
}
//方法结束，需要将变量的值带出方法

//求和方法
public static void SumNumber(int a, int b,out int sum)
{
    sum = 0;
    for (int i =a; i <= b; i++) 
    {
        sum += i;
    }
}
```

:two:提示用户输入两个数字，并计算两个数字之间所有整数之和

```csharp
static void Main(string[] args)
{
    string[] strArr = { "格温", "米勒", "内瑟斯", "蒂姆邓肯", "科比布莱恩特" };
    string maxStr = GetIndex(strArr);
    Console.WriteLine(maxStr);
}
public static string GetIndex(string[] arr) 
{
    string maxStr = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > maxStr.Length) 
        {
            //循环变量长度>假定最大元素长度，则赋值给maxStr
            maxStr = arr[i];
        }
    }
    return maxStr;
}
```

:three:计算整型数组的平均值。

```csharp
static void Main(string[] args)
{
    int[] arr = { 3, 4, 5, 67, 45 };
    double avg = CalculateAvg(arr);
    avg = Res(avg);
    Console.WriteLine(avg);
}
// 计算整型数组平均值
public static double CalculateAvg(int[] arrNums) 
{
    double sum = 0;
    for (int i = 0; i < arrNums.Length; i++) 
    {
        sum += arrNums[i];
    }
    return sum / arrNums.Length;
}
//保留两位小数
public static double Res(double num) 
{
    string s = num.ToString("0.00");
    //转化成两位小数形式的字符串
    num = double.Parse(s);
    return num;
}
```

:four:判断用户输入的数字是不是质数，要求只能输入数字，否则要求用户重复输入。

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入一个数字");
    string strNum = Console.ReadLine();
    int num = GetNum(strNum);//拿到一个正确的数字
    Judge(num);//判断是否为质数
}
//将文本数字转化为int数字
public static int GetNum(string strNum) 
{
    while (true) 
    {
        try
        {
            int num = int.Parse(strNum);
            return num;//成功转换就退出方法
        }
        catch
        {
            Console.WriteLine("输入非法字符，请重新输入");
            strNum = Console.ReadLine();
        }
    }
}//方法结束

//判断一个数是否为质数
//只能被1和他本身整除
public static void Judge(int num) 
{
    if (num > 1)
    {
        bool b = true;
        for (int i = 2; i <= num - 1; i++)
        {
            if (num % i == 0)
            {
                b = false;//被其他数整除就不是质数
                break;
            }
        }
        if (b)
        {
            Console.WriteLine("{0}是质数", num);
        }
        else
        {
            Console.WriteLine("{0}不是质数", num);
        }
    }
    else 
    {
        Console.WriteLine("小于等于1的都不是质数");
    }
}
```

:five:接受输入后，判断其等级并显示出来。优：90 ~ 100；良：80 ~ 89；中60 ~ 69；差：0~59.

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入你的成绩");
    int score = int.Parse(Console.ReadLine());
    string assess = Assess(score);
    Console.WriteLine(assess);
}
public static string Assess(int score)
{
    if (score >= 90)
    {
        return "优";
    }
    else if (score >= 70)
    {
        return "良";
    }
    else if (score >= 60)
    {
        return "中";
    }
    else
    {
        return "差";
    }
}
```

:six:将字符串数组`{"中","美","日","英","法"}`内容反转。数组不需要`ref`参数，会直接改变变量的值。

```csharp
static void Main(string[] args)
{
    string[] strArr = { "中", "美", "日", "英", "法" };
    RevStr(strArr);//数组不需要ref会直接改变变量的值
}

//将原数组内容反转
public static void RevStr(string[] arr) 
{
    for (int i = 0; i < arr.Length/2; i++) 
    { 
        string temp = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = temp;
    }
}
```

:seven:计算圆面积与周长的方法。

```csharp
 //静态字段模拟全局变量
 public static double _pi = 3.14;
 static void Main(string[] args)
 {
     Console.WriteLine("输入圆半径");
     double r = double.Parse(Console.ReadLine());
     double cir;
     double area = Area(r,out cir);
     Console.WriteLine("面积是{0:0.00},周长是{1}",area, cir);
 }

 //计算圆面积与圆周长
 public static double Area(double r,out double circumference) 
 {
     double area = Math.Pow(r, _pi);
     circumference = 2 * _pi * r;
     return area;
 }
```

:eight:计算任意多个数之间的最大值。

```csharp
static void Main(string[] args)
{
    int max = GetMax(1, 2, 3, 4, 56, 52, 3, -5);
    Console.WriteLine(max);
}
//计算多个数之间最大值方法
public static int GetMax(params int[] arr) 
{
    int max = arr[0];//假设最大值是数组第一个数字
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > max) 
        {
            max = arr[i];
        }
    }
    //循环结束后找出最大值，这时reurn
    return max;//返回最大值
}
```

:nine:通过冒泡排序对整数数组`{1,3,5,7,90,2,4,6,8,10}`进行升序排列

```csharp
static void Main(string[] args)
{
    int[] arr = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
    Res(arr);
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.WriteLine(arr[i]);
    }

}
public static void Res(int[] arr) 
{
    for (int i = 0; i < arr.Length-1; i++) 
    {
        for (int j = 0; j < arr.Length - 1 - i; j++) 
        {
            if (arr[j] > arr[j + 1]) 
            { 
                //满足条件则交换位置
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
```

:keycap_ten:将一个字符串数组输出为|分割形式。

```csharp
 static void Main(string[] args)
 {
     string[] names = { "易", "剑", "罗", "卡", "西" };
     string str = Change(names);
     Console.WriteLine(str);
 }
 public static string Change(string[] strs) 
 {
     string name = null;
     for (int i = 0; i < strs.Length - 1; i++)
     {
         name += strs[i] + "|";
     }
     return name += strs[strs.Length - 1];
 }
```