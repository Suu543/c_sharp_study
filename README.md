# c_sharp_study

![img](https://cdn-images-1.medium.com/max/880/1*_oGb_P-DXpPMcCoYE_2IHw.png)



![img](https://cdn-images-1.medium.com/max/880/1*WiCFiJ1OJtCEk883QJnC8Q.png)

### **C# vs .NET**

C# is a programming language, while .NET is a framework. It consists of a run-time environment (CLR) and a class library that we use for building applications.

### **CLR**

When you compile an application, C# compiler compiles your code to IL (Intermediate Language) code. IL code is platform agnostics, which makes it possible to a take a C# program on a different computer with different hardware architecture and operating system and run it. For this to happen, we need CLR. When you run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. This process is called Just-in-time Compilation (JIT).

### **Architecture of .NET Applications**

In terms of architecture, an application written with C# consists of building blocks called classes. A class is a container for data (attributes) and methods (functions). Attributes represent the state of the application. Methods include code. They have logic. That's where we implement our algorithms and write code.

A namespace is a container for related classes. So as your application grows in size, you may want to group the related classes into various namespaces for better maintainability.

As the number of classes and namespaces even grow further, you may want to physically separate related namespaces into separate assemblies. An assembly is a file (DLL or EXE) that contains one or more namespaces and classes. An EXE file represents a program that can be executed. A DLL is a file that includes code that can be re-used across different programs.

In the next section, you'll learn about basics of the C# language, including variables, constants, type conversion and operators.

## Variables and Constants

- Variable: a name given to a storage location in memory
- Constant: an immutable value
  - ex) Pi = 3.14

##  Declaring Variables / Constants

```c#
// 1. start with type
// 2. followed by identifier
// 3. finally semi-colon

// Cannot use a variable unless you assign a value to a variable
int number;
int Number = 1;
const float Pi = 3.14f;
```

## Identifiers

- Cannot start with a number
- Cannot include a whitespace
- Cannot be a reserved keyword
- Use meaningful names

## Naming Conventions

```c#
// Camel Case
firstName
    
// Pascal Case
FirstName
    
// Hungarian Notation
// data type + name
// It is not used in C#
strFirstName
    
// For local variables: Camel Case
int number;

// For constants: Pascal Case
const int MaxZoom;
```

![img](https://cdn-images-1.medium.com/max/880/1*1AsTdcyPzh3iRvS8-nukeA.png)

- C# types are always lowercase
- Google: C# built-in types
- http://msdn.microsoft.com/en-us/library/cs7y5x0x(v=vs.90).aspx

![image-20210301022836335](C:\Users\jos50\AppData\Roaming\Typora\typora-user-images\image-20210301022836335.png)

`double`이 `Real Numbers`의 기본값이기 때문에 따로 명시하지 않는다면 `double`로 간주된다. 나머지 `float`와 `decimal`은 명확히 명시해줘야한다.

## Overflowing

![image-20210301023028951](C:\Users\jos50\AppData\Roaming\Typora\typora-user-images\image-20210301023028951.png)

`byte` 데이터 타입의 변수에 담을 수 있는 최대값이 `255`다. 하지만 `255+1`을 했기 때문에, `Overflow`가 발생한다. 

![img](https://cdn-images-1.medium.com/max/880/1*2t0jzjQckvjjRFlAzvJaTQ.png)

위와 같이 `checked { }`를 작성해 코드를 감싸주면, 런타임에 `overflow`가 발생하지 않고 대신에 예외 처리(Advanced 에서 다룰 내용)를 한다. 하지만 이 방법을 사용하는 경우는 한 번도 본 적이 없다. 왜냐하면 간단하게 더 큰 숫자를 포함할 수 있는 `(short 등)` 데이터 타입을 사용하면 되기 때문이다.

## Scope

- Where a variable / constant has meaning or accessible

![img](https://cdn-images-1.medium.com/max/880/1*855lTFRgs_TyC7BYRCs-Mw.png)

`byte c` 가 있는 `block`에서는 `b`와 `a`에 접근할 수 있고, `byte b`가 있는 `block`에서는 `a`에 접근할 수 있고, `byte a`가 있는 `block`에서는 `b`와 `c`에 접근할 수 없다.

## Variables and Constants Practice

```c#
// Debugging Purpose : ctrl + shift + b
```

## Type Conversion

- Implicit Type Conversion
- Explicit Type Conversion
- Conversion between non-compatible types

```c#
// Implicit Type Conversion - No Data Loss
byte b = 1; //                            00000001
int i = b;  // 00000000 00000000 00000000 00000001 

int i = 1;
float f = i;

int i = 1;    // 4 bytes
byte b = i;   // 1 bytes // won't compile due to the data loss (beyond the capacity of its type)

// Explicit Type Conversion
// You are aware of data loss and we still want to convert it
int i = 1;
byte b = (byte)i
    
float f = 1.0f;
int i = (int)f;

// Not Compatible each other
string s = "1";
int i = (int)s; // won't compile

// Non-Compatible types
string s = "1";
int i = Convert.ToInt32(s); 
int j = int.Prase(s);

// Convert
- ToByte()
- ToInt16()
- ToInt32()
- ToInt64()
```

## Operators

- Arithmetic Operators
- Comparison Operators
- Assignment Operators
- Logical Operators
- Bitwise Operators

![img](https://cdn-images-1.medium.com/max/880/1*SwzFg3NPPN7bmkhaWpqfKg.png)

![img](https://cdn-images-1.medium.com/max/880/1*04ShpK1cZ5qoYn6hoLZ4yw.png)

![img](https://cdn-images-1.medium.com/max/880/1*G639MGHQKt36XvzRr7EU_A.png)

![img](https://cdn-images-1.medium.com/max/880/1*NuhUd5XzITe3UOjjGA6Zsw.png)

![img](https://cdn-images-1.medium.com/max/880/1*Xkv5T7ndV9tMbxCHJXf91g.png)

![img](https://cdn-images-1.medium.com/max/880/1*7soyq8bKczpFjGhWFSINyg.png)

![img](https://cdn-images-1.medium.com/max/880/1*8VKxaKejvVRmt128yClXgQ.png)

 [Logical-Operations.pdf](..\..\..\Downloads\Logical-Operations.pdf) 

### Comments

```c#
// Single-Line Comments
// Here is a single-line comment
int a = 1;

// Multi-Line Comments
/*
Here is a single-line comment
*/

// When to use
// - To explain whys, hows, constrains, etc. not the whats.
```

