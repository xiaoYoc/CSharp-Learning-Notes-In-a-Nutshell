# 面向对象基本概述

面向过程：面向的是完成这件事的过程，强调的是完成这件事的动作。

如把大象关进冰箱：`1.`打开冰箱门`2.`把大象塞进去`3.`关闭冰箱门

面向对象思想：找个对象帮你做事（强调对象，意在写出通用代码，屏蔽差异）。

将冰箱作为对象，把大象关进冰箱（可以屏蔽所有人的差异）。

1. 冰箱门可以被打开
2. 大象可以塞进冰箱
3. 冰箱门可以被关闭

也可以把大象放在柜子里，柜子也可以被打开，塞东西，被关闭。

对象必须是看的见，摸得着的实物。我们在代码中描述对象，通过描述这个对象的属性和方法，如：

| 电风扇的属性 | 电风扇的方法 |
| ------------ | ------------ |
| 外形         | 转动         |
| 颜色         | 扇风         |

我们把这些具有相同属性和方法的对象进行封装，抽象出类这个概念。（类相当于模子，确定了对象应该具有的属性和方法。）对象就是类创建出来的。

1. 创建一个things类，方法是打开，装东西，关闭。
2. 创建任意对象都有这个功能。

## 类的基本语法

```csharp
[public] class 类名//类名符合Pascal规范
{
    构造函数：依次为对象的属性赋值（实例化类以后）;
    字段：存储数据；
    属性：保护字段，对字段的赋值和取值进行限定；
    方法：描述对象的行为；
    索引器;
    析构函数：主要是在程序结束时立即释放内存；
}
//写好一个类，我们需要使用关键字new创建这个类的对象。这个过程叫类的实例化
```

创建一个`Car`类。

```csharp
internal class Car
{
    public string _type;//类型
    public int _wheel;//轮子数量
    public int _maxSpeed;//最高速度
    public void Action() 
    {
        Console.WriteLine("汽车类型{0},有{1}个轮子,最高速度{2}Km/h",
                          this._type,this._wheel,_speed);
    }
}
```

**this指的是这个类的对象,用来区分字段与形参**。

创建类的实例（类的实例化），之后给对象的属性或字段赋值时叫做对象的初始化。

```csharp
//Main函数入口
static void Main(string[] args)
{
    //创建Car类的一个对象，类的实例化
    Car car = new Car();
    //给字段赋值或给属性赋值叫做对象的初始化
    car._type = "轿车";
    car._wheel = 4;
    car._maxSpeed = 200;
}
```

内部执行过程：

:one:创建`car`对象（类的实例化），编译器会自动给字段赋予初值（初值由类型决定,值类型为`0`，引用类型为`null`）。换句话说类是不占内存的，而创建的对象是占内存的。

![类的实例化](assets/1739712309339-04c30fd3-e59f-4f76-91ca-86e72db272f0.png)

```csharp
static void Main(string[] args)
{
    Car car; //null
    car = new Car();//实例化类以后字段会有初始值
}
```

:two:对象的初始化：依次给对象的字段或属性赋值，:red_circle:只有给属性赋值时才会执行`set`方法。

## readonly修饰符

> `readonly`修饰符可作用与字段，作用同`Const`，不同的是`readonly`修饰符作用的变量，其值可在编译器决定，也可在程序运行时决定。

:one:只读字段可以在声明时直接赋值，或者在构造函数中赋值，不能再其他类中对只读字段赋值。

```c#
internal  static class Test
{
    //静态只读字段声明时直接初始化
    public readonly static double Pi = 3.14;
    ////静态字段须在静态构造函数中初始化。
    public readonly static double radius;
}
```

## 属性

属性的作用是保护字段，对字段的赋值和取值进行限定。

属性的本质是两个方法，一个是`get`，一个是`set`。

1. 给属性赋值会执行`set`方法，将值`value`赋值给字段；
2. 读取属性的值时会执行`get`方法，取字段的值。

在类中，为保护字段存储的数据，应该设置为私有访问修饰符`private`，通过中间商属性去读取字段。

| 属性中的方法 | 类型         |
| ------------ | ------------ |
| 有get也有set | 可读可写属性 |
| 仅get        | 只读属性     |
| 仅set        | 只写属性     |

```csharp
internal class Car
{
    private string _name;
    //private私有访问权限，仅本类中能访问
    public string Name 
    {
        //获取属性值执行get方法
        get { return _name; }
        //设置属性值执行set方法
        set { _name = value; }
    }
    private int _speed;
    //若给属性赋值的速度小于0，则返回默认值0
    public int Speed 
    {
        get { return _speed; }
        set 
        {
            if(value < 0) return; 
            _speed = value;
        }
    }
    ///品牌，自动属性，详见自动实现属性章节
    public string Brand { set; get; }
    public void Show() 
    {
        Console.WriteLine("品牌{3},车类型{0},速度{1}Km/h,",
                          this.Name,this.Speed,this.Brand);
    }
}
static void Main(string[] args)
{
    //创建一个对象后字段会有初始值，且对象的属性与初始值一致
    Car car = new Car();
    //对象的初始化，给属性赋值会执行set方法
    //注意给字段赋值不会执行set方法
    car.Name = "卡车";
    car.Speed = -1;//执行set方法，返回字段默认值0
    car.Brand = "*";
    //Show法会打印对象的属性，此时执行get方法
    car.Show();
}
```

执行过程：

1. 实例化一个`car`对象，**字段与属性会获得与其类型对应的值**。
2. 对象的初始化，给属性赋值会执行`set`方法，给字段赋值。
3. 调用对象的`Show`方法，内部会访问对象的属性，此时调用属性的`get`方法，取得字段存储的值。

:red_circle:关于调试方面的问题：

调试时属性的值可能与预设想的不一致，是因为查看属性时调试器隐式调用了`get`方法，执行了其中的逻辑，所以在调试时应注意到此问题，尽可能用字段去调试。

```csharp
public int Speed 
{
    get 
    {
        _speed = -100;
        return _speed; 
    }
    set 
    {
        if(value < 0) { return; }
        _speed = value;
    }
}
```

将上述的`Speed`属性做这样的更改，且在`set`方法上打上断点，给属性赋值时（`car.Speed = -1`），按原逻辑返回的是默认值0,；我们在执行get方法时查看`Speed`属性，则会隐式调用`get`方法，将字段_`speed`值更改为`-100`.

### 自动属性

不需要显示声明一个私有变量，编译器会自动生成一个私有字段存储值（必须有`get`方法），适合不需要逻辑处理的属性。

1. 自动属性访问器后可赋一个默认值，普通属性无此语法。
2. 自动实现属性必须要有`get`访问器。

```csharp
public class Tractor 
{
    public int Wheel { get; set; } = 4;//默认值4

    public string Color { get; set; } = "green";//默认值green

    public int Sates {  get; set; }//默认值0
    public void Show() 
    {
        Console.WriteLine("this tractor has {0} wheels,it's {1},it has {2} sates",
                          this.Wheel,this.Color,this.Sates);
    }
}
//创建对象后，若未给属性赋值，则调用Show方法，读取字段默认值
```

### 只读属性与只读自动属性

只读属性通常用一个`get`访问器实现 或者将`set`访问器私有化来实现，在构造函数中初始化字段值。

:one:只读属性的基本实现

```csharp
public string Name { get;}//自动只读属性
private int _wheel;
public int Wheel { set { _wheel = value; }}//只写
public string Name { get; private set;}//只读
```

:two:只读属性在构造函数中初始化

```csharp
internal class Car
{
    public Car(string type,int wheel) 
    { 
        //在构造函数内赋值，也可以进行复杂的逻辑处理
        this._type = type;
        this._wheel = wheel;
    }
    private string _type;
    public string Type 
    { 
        get
        {
            //获取属性值时,字段会更改为三轮
            _type = "三轮";
            return _type; 
        }
    }
    private int _wheel;
    public int Wheel 
    {
        get { return _wheel; }
    }
}
//Main函数中调用
static void Main(string[] args)
{
    //创建Car类的一个对象，类的实例化
    Car car = new Car("轿车",4);
    //在构造函数未执行之前，字段与属性会获得与类型相对应的值
    Console.WriteLine(car.Type);
```

:three:只读自动属性在构造函数中初始化

```csharp
internal class Car
{
    public Car(string type,int wheel) 
    { 
        //执行构造函数之前，属性的初始值与其类型相对应
        this.Type = type;
        this.Wheel = wheel;
    }
    public string Type  { get; }
    public int Wheel {get; }
}
```

## 静态与非静态类

### 非静态类

1. 在**非静态类**中既可以有实例成员(非静态成员)，也可以有静态成员。

1. 在调用实例成员的时候，需要使用`对象名.实例成员`。
2. 在调用静态成员时，使用`类名.静态成员`（若在同一类中，可省略类名）。

```csharp
public class Person
{
    string _exOne = "非静态";//实例
    public string ExOne 
    { 
        get { return _exOne; }
    }
    static string _exTwo = "静态";
    static public string EXTwo 
    {
        get { return _exTwo; }
    }
    public void MethOne()
    {
        Console.WriteLine(_exOne);
        Console.WriteLine(_exTwo);//实例函数中可以访问实例与静态成员
    }
    public static void MetTwo()
    {
       Console.WriteLine(_exTwo);
       //Console.WriteLine(_exOne);静态方法中不能使用实例成员
    }
}
```

### 非静态类中的静态方法与实例方法

静态成员在类首次调用前加载，即未实例化前就可以直接访问，而实例成员在实例化后才会分配内存，因此在静态方法中不能直接访问实例成员，若需要访问，则在参数中显式传递实例成员。

在内存方面：静态成员在静态存储区域中只有一份拷贝（如静态字段模拟全局变量），而实例成员每个实例都有自己的拷贝。

注意一下两点：

1. **静态方法中**，能直接访问静态成员，不能直接访问实例成员。
2. 实例方法中，既可以使用静态成员，也可以访问实例成员。

```csharp
//静态类Test
internal static class Test
{
    //在静态类中访问实例属性
    public static void Print(Vector3 v) 
    {
        Console.WriteLine(v.X);
    }
}
//在main函数中调用
static void Main(string[] args)
{
    Vector3 v1 = new Vector3(1, 2, 4,7);
    //调用静态类中的静态函数
    Test.Print(v1);//输出1
}
```

### 静态类

**静态类**中只允许静态成员，不允许出现实例成员。且对于静态类，不允许实例化，也不允许继承。

1. 如果一个类作为工具类使用时，可以考虑写成静态类。
2. 静态类在整个项目中资源共享。
3. 静态字段和静态属性会在类首次调用前加载，且有默认值（用户定义或者编译器提供）。
4. 之后自动执行静态构造函数。

只有在程序全部结束后，静态类才会释放资源。

```csharp
static Test()//必须无参数
{
    //相关代码
}
```

静态类可以使用this关键字拓展方法，像`对象.方法`一样去调用，见`this`章节。

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        string str = "this的拓展方法";
        str.Print();
    }
} 
//this的拓展方法
internal static class Person
{
    public static void Print(this string name) 
    {
        Console.WriteLine(name);
    }
}  
```

## 构造函数

帮助我们初始化对象，通过属性给给私有字段依次赋值。

1. 构造函数没有返回值，连void都没有
2. 构造函数的名称必须跟类名一致。
3. 实例化对象时会自动执行构造函数。

------

类当中会有一个默认的无参的构造函数，当你写了一个新的构造函数之后，不论是否有参数，原默认无参构造函数都会被代替。

```csharp
internal class Student
{
    public Student(string name,char gender,int age,int math,int english,int chinese) 
    {
        this.Name = name;
        this._gender = gender;//Gender属性只读
        this.Age = age;
        //只读自动属性:直接给属性赋值
        this.Math = math;
        this.English = english;
        this.Chinese = chinese;
    }
    /// <summary>
    /// 自动实现属性，编译器隐式声明变量存储值
    /// </summary>
    public string Name { get; set; }
    private char _gender;
    public char Gender
    {
        get { return _gender; }
    }
    private int _age;
    public int Age 
    {
        get { return _age; }
        set
        {
            if(value < 0) 
            {
                value = 0;
            }
            _age = value;
        }
    }
    public int Math { get; }
    public int English { get; }
    public int Chinese {  get; }
}
```

在Main中初始化对象，以及调用。注意此时`new`关键字的作用：

1. 在堆中开辟一个空间
2. 在空间中创建一个对象，编译器自动加载字段与属性，其值可能是用户定义的默认值，也可能是编译器提供默认值。
3. 调用对象的构造函数进行初始化。

```csharp
internal class Program
{ 
    static void Main(string[] args)
    {
        //类实例化后通过构造函数进行对象的初始化
        Student st = new Student("占山",'女',13,120,100,100);
    }
}
```

写一个`Ticket`类，有一个距离属性（只读，在构造函数中赋值且不能为负数），有价格属性，只读，且根据距离计算价格。

```csharp
internal class Ticket
{
    public Ticket(double distance) 
    {
        if (distance < 0) 
        {
            distance = 0;
        }
        this.Distance = distance;
    }
    public double Distance { get; }//只读自动实现属性
    private double _price;
    public double Price //逻辑代码
    {
        get 
        {
            if (this.Distance <= 100)
            {
                //100公里原价
                _price = this.Distance * 1;
            }
            else if (this.Distance <= 200)
            {//95折
                _price = this.Distance * 0.95;
            }
            else if (this.Distance <= 300)
            {//9折
                _price = this.Distance * 0.9;
            }
            else 
            {
                _price = this.Distance*0.85;
            }
            return _price; 
        }
    }
}
```

## this关键字

:one:this代表当前类的对象，主要用来**区分属性与形参或方法中的局部变量。**

:two:在类当中显式调用本类的构造函数。先执行调用的构造函数，再执行本身的构造函数。

:three:用于静态类中的拓展方法，像实例一样去调用方法，也可以用类名.方法去调用。

:four:声明索引器。

```csharp
internal class Ticket
{
    public Ticket(int distance)
    {
        //对参数进行判断，将值赋给字段_distance
        if(distance < 0) 
        {
            this._distance = 0;
        }
        else 
        {
            this._distance = distance;
        }
    }
    public Ticket(int distance , int hour):this(distance) 
    { 
        this.Hour = hour;
    }
    private int _distance;
    public int distance
    {
        //只读
        get { return _distance; }
    }
    private double _price;
    public double Price 
    {
        get 
        { 
            if(this.distance <= 100) 
            {
                _price = this.distance * 1;
            }
            else if(this.distance <= 200) 
            {
                _price = this.distance * 0.95;
            }
            else if(this.distance <= 300) 
            {
                _price = this.distance * 0.9;
            }
            else 
            {
                _price = this._distance * 0.85;
            }
            return _price; 
        }
    }
    public int Hour { get; }
}
```

拓展方法：

```csharp
//拓展方法必须存在静态类中
public static class ExtenSion
{
    public static void Print(this string name) 
    {
        Console.WriteLine("用户{0}定义的拓展方法",name);
    }
}
//Main函数中调用
static void Main(string[] args)
{
    string name = "lzb";
    ExtenSion.Print("张三");//类名.方法调用
    name.Print();//变量.方法调用
}
```

## 索引器

> 索引器类似于属性，有`get`和`set`访问器，可访问多个数据成员。
>
> 索引器没有名称，用`this`去指代当前名称。
>
> 索引器必须是实例

```c#
public struct Color
{
    public static readonly int _red = 1;
    public static readonly int _green = 2;
    public static readonly int _blue = 3;
}

internal class IndexDemo
{
    private string _color;
    //索引器没有名称，用this指代
    //[]中可是是任何类型
    public string this[int index]
    {
        get
        {
            switch (index)
            {
                case 1:
                    _color = "red";
                    break;
                case 2:
                    _color = "green";
                    break;
                case 3:
                    _color = "blue";
                    break;
            }
            return _color;
        }
    }
}
//主函数中调用
static void Main(string[] args)
{
    IndexDemo demo = new IndexDemo();
    Console.WriteLine(demo[Color._red]);
}
```



## 析构函数

程序结束的时候，析构函数才会被执行，意在帮助我们释放资源。

如果希望程序技术立即释放内存资源，就使用析构函数，不需要则通过GC(Garbage Collection-垃圾回收装置)自动释放资源

```csharp
~类名()
{
    //代码区域
}
//示例
 ~Student() 
 {
     Console.WriteLine("程序结束才会执行，无需在Main函数中调用");
 }
```

## 命名空间

命名空间用于解决类的重名问题，相当于`类的文件夹`,类是属于命名空间，如果当前项目没有这个类的命名空间，我们需要导入类的命名空间。

导入命名空间快捷键：`ALT+Enter`，然后选择需要的命名空间。

在一个项目中引用另一个项目的类：

1. 添加引用
2. 引用命名空间

## 部分类

适用于多人开发时，同时存在同一个类，在类前加`partial`关键字，则代表一个完整的类被分给为几块，各个部分可以访问相关成员，本质就是一个整体。



```csharp
public abstract partial class Animal
{

    public abstract void Bark();
}
//部分类二
public abstract partial class Animal
{
    //代码体
}
```

# 面向对象之继承

>  把重复的成员单独封装到一个类中来作为父类。
>
> 子类继承父类的`属性和方法`以及字段，但由于字段的私有性，子类无法访问。
>
> 没有继承父类的构造函数，但是子类会默认调用父类无参的构造函数，目的是初始化父类成员，让创建的子类对象包含父类的成员。
>
> 继承的特性：
>
> 1. 单根性：只能由一个父类
> 2. 传递性：最上层的父类的属性和方法会传递到最下层的子类。



1. ![img](assets/1740049669539-cc55c7a9-373a-41f9-8ab8-4883ef1a0690.jpeg)

1. 简单的认识继承

1. 定义父类`Car`

```csharp
public class Car 
{
    private string _name;
    public string Name
    {
        set {  _name = value; }
        get { return _name; }
    }
    private int _wheel;
    public int Wheel 
    {
        set { _wheel = value; }
        get { return _wheel; }
    }
    public void Show() 
    {
        Console.WriteLine("车类型{0},轮子数量{1}",this.Name,this.Wheel);
    }
}
```

1. 定义子类`Tractor`

```csharp
public class Tractor:Car 
{
    public Tractor(string name,int wheel) 
    {
        this.Name = name;
        this.Wheel = wheel;
    }
}
```

1. `Main`函数中调用

```csharp
static void Main(string[] args)
{
    Tractor tc = new Tractor("tractor", 4);
    tc.Show();
    //先调用父类的构造函数，给父类成员赋值
    //再执行自己的构造函数
}
```

1. 继承的传递性：C继承B,B继承A，C具有B和A的公有属性和方法；先执行最上层的父类构造函数，依次向下执行构造函数，最后才执行自己的构造函数。

```csharp
public class Car
{
    public string Name { get; set; }
    public int Wheel {  get; set; }
}

public class Tractor : Car
{
    public int ChangeYear { get; set; }
}
public class WalkingTractor:Tractor
{
    //声明构造函数，初始化对象
    public WalkingTractor(string name,int wheel,int changeYear,int speed ) 
    { 
        this.Name = name;
        this.Wheel = wheel;
        this.ChangeYear = changeYear;
        this.Speed = speed;
    }
    public int Speed {  get; set; }
}
```

小知识：不能在子类构造函数中为父类的自动只读属性赋值，因为父类已经实现了逻辑，不希望子类破坏，除非隐藏或重写。

了解：`object`类是所有类的基类，如果一个类没有继承其他类，默认继承`object`类。

## base关键字

如果在父类中重新写了一个有参数的构造函数后，无参数的构造函数被顶替，子类调用不到会报错。

解决办法：

1. 在父类重写一个无参数的构造函数
2. 在子类中显式调用父类的构造函数，使用关键字`:base`。

```csharp
public class Car
{
    public Car(string name,int wheel) 
    {
        this.Name = name;
        this.Wheel = wheel;
    }
    public string Name { get; set; }
    public int Wheel {  get; set; }
}

public class Tractor : Car
{
    //显式调用父类的构造函数
    public Tractor(string name,int wheel,int changeYear) 
        : base(name, wheel) 
    {
        this.ChangeYear = changeYear;
    }
    public int ChangeYear { get; set; }
}
```

## new关键字

new关键字的作用：

1. 创建对象
2. 隐藏从父类那里继承的同名成员（不写new同样会隐藏父类成员，不过编译器会进行提示），隐藏的后果是调用不到父类的成员。

```csharp
public class Car
{
    public Car(string name,int wheel) 
    {
        this._name = "CAR";
        this.Wheel = wheel;
    }
    private string _name;
    public string Name 
    {
        get { return _name; } 
    }
    public int Wheel {  get; set; }

    public void Show() 
    {
        Console.WriteLine("车名：{0}，轮子{1}",this.Name,this.Wheel);
    }
}

public class Tractor : Car
{
    public Tractor(string name,int wheel,int changeYear) 
        : base(name, wheel) 
    {
        this.ChangeYear = changeYear;
    }
    //隐藏父类Name属性
    private string _name;
    public  new string Name 
    { 
        get {return _name;} 
        set { _name = value;}
    }
    public int ChangeYear { get; set; }

    public new void Show() 
    {
        Console.WriteLine("车名：{0}，轮子{1},生产日期{2}", this.Name, 
                          this.Wheel,this.ChangeYear);
    }
}
```

在Main函数中调用：

```csharp
static void Main(string[] args)
{
    Tractor tr = new Tractor("拖拉机",4,2015);
    tr.Show();
}
```

在上述例子中子类隐藏了父类的`Name`属性和`Show`方法，执行过程如下：

1. 先执行父类的构造函数，初始化父类的成员，确保子类方法可以正确访问父类成员；
2. 再执行子类的构造函数，初始化子类中成员；
3. 执行方法时调用的是子类的`Show`方法，`this`遵循就近原则，子类中有`Show`方法就不会调用父类的方法。
4. 上述例子中子类构造函数并没有初始化Name属性，所以子类中的`Name`属性值为`null`。

子类中的对象有两个`Name`属性，一个是父类的`Name`,一个是自己的`Name`，字段与方法也同样如此。

可使用`base`访问父类属性，`base.名`代表当前对象调用继承的父类的属性名或方法名。

```csharp
public new void Show() 
{
    Console.WriteLine("车名：{0}，轮子{1},生产日期{2}", 
                      base.Name, this.Wheel,this.ChangeYear);
}
```

## 里氏转换

向上转型，使父类访问子类的属性与方法。

1. 子类可以转换为父类,此时的对象优先访问自己的父类成员，除非实现了多态：

1. 子类方法override重写父类虚方法，调用子类的方法
2. 抽象，接口父类调用子类实现的方法。

1. 如果一个地方需要父类作为参数，我们可以给一个子类代替，如`string.Join(string sep,params object[] values)`
2. 如果父类中装的是子类对象，可以将父类对象强转为子类对象。

子类赋值给父类，转换为父类。父类可强转为子类。

定义一个`Car`类，`Tractor`类与`ThreeWheel`继承于`Car`类。

```csharp
public class Car
{
    public Car(int wheel, string brand)
    {
        this.Wheel = wheel;
        this.Brand = brand;
    }
    public int Wheel { get; } = 4;//默认值4
    public string Brand { get; }
}
//增加Weight属性
public class Tractor : Car
{
    public Tractor(int wheel, string brand,double weight):base(wheel,brand)
    {
        this.Weight = weight;
    }
    public double Weight { get; }
}

//与父类属性一致
public class ThreeWheel : Car
{
    public ThreeWheel(int wheel, string brand) : base(wheel, brand)
    {
    }
}
```

在Main函数中调用

```csharp
static void Main(string[] args)
{
    //把子类对象装到父类对象中
    Car trc = new Tractor(2, "拖拉机", 1000);
    //Console.WriteLine(trc.Weight);可以查看到，但无法访问
    Tractor tractor = (Tractor)trc;
    Console.WriteLine(tractor.Weight);//1000
    //属性并未丢失，只是父类对象访问不到，只能访问二者公有的成员
}
```

### 类型转换判断

#### is

如果转换成功，返回一个`true`，否则返回一个`false`。

```csharp
static void Main(string[] args)
{
    Car trc = new Tractor(2, "拖拉机", 1000);
    if (trc is Tractor)
    {
        Console.WriteLine("trc 能转成Tractor类型");
    }
    else 
    {
        Console.WriteLine("无法转换");
    }
}
```

#### as

能够转换则返回对应的对象，否则返回`Null`。

```csharp
static void Main(string[] args)
{
    Car trc = new Tractor(2, "拖拉机", 1000);
    Tractor tractor = trc as Tractor;//可以转换
    ThreeWheel thr = trc as ThreeWheel;//null
}
```

#### 练习

把子类放到父类数组中，打印子类中的方法。

```csharp
//Person类中有打招呼方法，子类各自隐藏父类打招呼方法
class Person
{
    public void SayHello() 
    {
        Console.WriteLine("大家好");
    }
}
class Chinese:Person
{
    public new void SayHello()
    {
        Console.WriteLine("安好");
    }
}
class English:Person
{
    public new void SayHello() 
    {
        Console.WriteLine("hi");
    }
}
```

在`Main`函数中执行逻辑：

```csharp
static void Main(string[] args)
{
    Person[] pers = new Person[6];
    //创建Person类型数组,值默认未null
    //即未开辟空间，不会初始化，不会执行构造函数
    Random random = new Random();//创建随机数对象
    for (int i = 0;i<pers.Length;i++)
    {
        int num = random.Next(1,4);//返回随机数1~3
        //根据随机数给数组赋值
        switch(num)
        {
            case 1:
                pers[i] = new Person();
                break;
            case 2:
                pers[i] = new Chinese();
                break;
            case 3:
                pers[i] = new English();
                break;
        }
    }
    //执行打招呼方法
    foreach (Person p in pers)
    {
        //转换类型，执行各自的打招呼方法
        if (p is Chinese)
        {
            ((Chinese)p).SayHello();
        }
        else if (p is English)
        { ((English)p).SayHello(); }
        else
        {
            //父类对象
            p.SayHello();
        }
    }
}
```

## 访问修饰符

能够修饰类的访问修饰符只有`public` 和 `internal`

在同一个项目当中，`public`和`internal`权限一样。

| 关键字             | 作用                                                       |
| ------------------ | ---------------------------------------------------------- |
| public             | 公开的                                                     |
| internal           | 只能在当前项目中访问                                       |
| protected          | 受保护的，当前类内部以及子类内部可以访问，出了类访问不到。 |
| protected internal | protected + internal                                       |
| private            | 私有的，仅当前类中能访问                                   |

可访问性不一致：

子类的访问权限不能高于父类访问权限，因为会暴露父类成员。

## 密封类

在类前加入关键字`sealed`,表示一个类是密封类，不能被继承，但能够继承它类。

```csharp
 public  sealed  class Animal
 {

     //public abstract void Bark();
 }

 public class Dog : Animal { }//无法从密封类中派生
```

# string

## 字符串的不可变性

当给字符串重新赋值时，老值并没有消失，而是在堆中开辟一块空间存储新值。

```csharp
static void Main(string[] args)
{
    //堆中开辟空间存储1，s1在栈内存储引用地址
    string s1 = "1";
    //堆中重新开辟空间存储"2",s1中原引用地址被替换掉，新地址指向"2"
    s1 = "2";
    Console.WriteLine(s1);//2
}
```

## 字符串的数组特性

可以将`string`类型看作是`char`类型的一个**只读数组**，根据索引访问字符串某个元素。

```csharp
string s = "adcd";
Console.WriteLine(s[1]);//d
```

改变字符串其中某个字符：

1. 转换为char类型数组；
2. 将数组转化为字符串。

```csharp
string s = "adcd";
char[] chas = s.ToCharArray();//返回char类型数组
//第一个元素变为A
chas[0] = 'A';
s = new string(chas);//通过string类实例化，将字符数组转化为字符串
Console.WriteLine(s);//Adcd
```

## StringBuilder类

由于字符串的不可变性，重新赋值需要不段开辟新空间，对于某些场合不适合

```csharp
static void Main(string[] args)
{
    Stopwatch sw = new Stopwatch();//创建一个实例
    sw.Start();//开始计时
    string s = null;
    for (int i = 0; i < 100000; i++) 
    {
        s += i;
    }
    sw.Stop();//结束计时
    Console.WriteLine(sw.Elapsed);//测量运行的总时间

}
//约10s
```

使用`StringBuilder`类

```csharp
static void Main(string[] args)
{
    Stopwatch sw =new Stopwatch();
    sw.Start();//开始计时
    StringBuilder sb = new StringBuilder();//实例化一个sb对象
    for (int i = 0; i <100000; i++) 
    {
        sb.Append(i);//追加
    }
    sw.Stop();//结束计时
    Console.WriteLine(sw.Elapsed);
}
//约0.01s
```

## 字符串方法与属性

### $_文本内使用变量

```c#
 int month = 3;
 int date = 29;
 Console.WriteLine($"0{month}月{date}日");//03月29日
```

`{}`内也可以直接写值

```c#
string name = $"{"this day is cold"}";
```

### Length属性

获取字符串的长度

```csharp
Console.WriteLine("请输入你心中所想的名字");
string s = Console.ReadLine();
Console.WriteLine(s.Length);
```

### ToUpper/ToLower_转化大写/小写

两个学员输入喜欢的课程，相同则输出相同，不同则输出不同。

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入喜欢的课程");
    string classOne = Console.ReadLine();
    //转换大写
    classOne = classOne.ToUpper();
    Console.WriteLine("请下一个学员");
    string classTwo = Console.ReadLine();
    //转换大写，返回一个字符串
    classTwo = classTwo.ToUpper();
    if (classOne == classTwo)
    {
        Console.WriteLine("相同");
    }
    else 
    {
        Console.WriteLine("不同");
    }
}
```

使用`Equals(与**相等)`方法，比较两个字符串是否相同，返回`bool`值。参数1待比较字符串，参数2枚举类型`StringComParison`，如何进行比较。

```csharp
static void Main(string[] args)
{
    Console.WriteLine("请输入喜欢的课程");
    string classOne = Console.ReadLine();
    Console.WriteLine("请下一个学员");
    string classTwo = Console.ReadLine();
    if (classOne.Equals(classTwo, StringComparison.InvariantCultureIgnoreCase)
        //忽略大小写进行比较
    {
        Console.WriteLine("相同");
    }
    else 
    {
        Console.WriteLine("不同");
    }
}
```

### Split()_分隔字符串

基于字符数组或字符串数组，将原字符串进行分隔，返回一个string数组。

重载:one:`str.Split(params char[] separator)`,

参数为分隔数组，`char[]`类型

重载:two:`str.Split(char[]/string[] separator,StringSplitOptions options)`

参数1分隔符数组，有字串或字符类型，参数2是`StringSplitOptions`枚举类型，可用来判断是否需要空字符串。

```csharp
string s = "a b   cdf _ + = , _";
//去除字符串中的空格，_,+，=
//参数1为分隔数组，参数2枚举值指定是否需要空字符串
char[] chars = {' ' ,'+',',','=','_'};
string[] strArr = s.Split(chars, StringSplitOptions.RemoveEmptyEntries);
//{a,b,cdf}
```

从字符串2008-08-08分隔出年月日。

```csharp
string s = "2008-08-08";
string[] strArr = s.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("{0}年{1}月{2}日", strArr[0], strArr[1], strArr[2]);
//2008年08月08日
```

### Replace()_替换

用新值替换旧值

```csharp
static void Main(string[] args)
{
    //Replace(string oldValue,string newValue)
    string str = "国家关键人物老宁";
    if (str.Contains("老宁"))//判断是否包含该字符串，返回bool
    {
        str = str.Replace("老宁", "**");
    }
    Console.WriteLine(str);
}
```

### SubString()_截取字符串

1. `SubString(int startIndex)`，从指定索引开始截取（包含指定索引），直到最后
2. `SubString(int startIndex，int length)`,从指定索引开始截取指定长度，且长度不能超出索引。

```csharp
string str = "艳阳天那么风光好";
str = str.Substring(3);//从指定索引开始截取，直到最后
Console.WriteLine(str);//那么风光好

//重载，参数2截取长度
string str = "艳阳天那么风光好";
str = str.Substring(3,2);
Console.WriteLine(str);//那么
```

### StartWith()_判断是否以指定字符串开头

返回Bool值，对应的方法是`EndWith()`.

```csharp
string str = "艳阳天那么风光好";
if (str.StartsWith("艳阳") )
{
    Console.WriteLine("是的");
}
```

### IndexOf()_查找字符/字符串的位置

返回int类型，找不到返回`-1`。

1. `IndexOf(string value)`,`value`要查找的字符或字符串，从前往后查找
2. `IndexOf(string value,int startIndex)`,`stringValue`要查找的字符，`startIndex`指定位置，从前往后查找

`LastIndexOf`同理，不过是从后往前查找。

```csharp
 string str = "天,今天天气真好";
 int num = str.IndexOf('天');//传入字符
 int num2 = str.IndexOf("天", 5);
 Console.WriteLine(num);//0
 Console.WriteLine(num2);//-1
```

截取文件名练习

```csharp
string path = @"C:\Users\Administrator\Desktop\学习资源";//@取消转义
int index = path.LastIndexOf('\\');//注意此处是\\。获取\的索引
string name = path.Substring(index + 1);
Console.WriteLine(name);//学习资源
```

### Trim()_去除空格

返回字符串，Trim()去除字符串前后空格。

1. `TrimStart()`,去除前空格
2. `TrimEnd()`去除后空格

```csharp
string str = "   学校      ";
str = str.Trim();
Console.Write(str);
Console.Write(1); //学校1
//去除前空格
string str = "   学校      ";
str = str.TrimStart();
Console.Write(str);
Console.Write(1); //学校   1
```

### string.Format()_格式化字符串

与占位符相同。

```c#
string str =  string.Format("{0},{1}", "A", "B");
```

### string.IsNullOrEmpty(string str)

判断字符串是`null`或者`""`，是则返回True.

```csharp
string str = "   学校      ";
if(!string.IsNullOrEmpty(str))
{
    Console.WriteLine('N');
}
```

### string.Join()_插入分隔符

在每个元素之间插入分隔符，返回`string`值。

```csharp
string[] name = { "张三", "李四", "王五", "马六" };
string str = string.Join("|", name);
Console.WriteLine(str);//张三|李四|王五|马六
```

## 练习

1. 读取文件，以`书名|作者名`形式打印到控制台，要求书名长度超过8个以后用`...`代替。

```csharp
明朝那些事儿            当前明月
坏蛋是怎样练成的怎样炼成的       六道
西游记                             吴承恩
水浒         施耐庵
static void Main(string[] args)
{
    string path = @"C:\Users\Administrator\Desktop\1.txt";
    string[] bookNames = File.ReadAllLines(path,Encoding.UTF8);
    //使用UTF8编码，每行内容是一个数组元素
    for (int i = 0; i < bookNames.Length; i++)
    {
        string[] temp = bookNames[i].Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries);
        //此处可以使用三元表达式，但是难看
        if (temp[0].Length <= 8)
        {
            Console.WriteLine(string.Join("|",temp));
        }
        else 
        {
            string name = temp[0].Substring(0, 8) + "..." + "|" + temp[1];
            Console.WriteLine(name);
        }
    }
}
```

1. 接收用户输入的字符串，将其中的字符以相反顺序输出，`abc→cba`。

```csharp
//方法一不改变数组元素顺序
static void Main(string[] args)
{
    Console.WriteLine("请输入...");
    string input = Console.ReadLine();
    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        Console.Write(chars[chars.Length-1-i]);
    }
}
//方法二改变数组元素顺序
static void Main(string[] args)
{
    Console.WriteLine("请输入...");
    string input = Console.ReadLine();
    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length/2; i++)
    {
        char cha = chars[i];
        chars[i] = chars[chars.Length-1-i];
        chars[chars.Length - 1-i] = cha;
    }
}
```

1. `hellp c sharp` →` sharp c hello`。

```csharp
static void Main(string[] args)
{
    string value = "hello c sharp";
    string[] values = value.Split(new char[] { ' '}, 
                                  StringSplitOptions.RemoveEmptyEntries);
    //Array.Reverse(values);直接使用reverse方法
    for (int i = 0; i < values.Length/2; i++)
    {
        string temp = values[i];
        values[i] = values[values.Length-1-i];
        values[values.Length-1-i] = temp;
    }
    value = string.Join(" ", values);
    Console.WriteLine(value);//sharp c hello
}
```

1. 从`email`中提取`QQ号`和`域名`。

```csharp
static void Main(string[] args)
{
    //471457680@qq.com
    string email = "471457680@qq.com";
    int index = email.IndexOf("@");
    string qqName = email.Substring(0, index);
    string yuName = email.Substring(index + 1);
    Console.WriteLine(qqName);
    Console.WriteLine(yuName);
}
//也可使用split方法
```

1. 让用户输入内容，显示所有`e`的位置。

```csharp
static void Main(string[] args)
{
    string value = "aewsewdasde";
    int index = value.IndexOf('e');
    int i = 1;
    while(index <= value.Length)
    {
        if (index != -1)
        {
            Console.WriteLine("第{0}个e，索引{1}", i, index);
            i++;
            index = value.IndexOf('e', index + 1);
        }
        else { break; }//搜索不到退出循环
    }
}
//也可以遍历字符串数组，判断是否==e，弊端只能用于字符
```