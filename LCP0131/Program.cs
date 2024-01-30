// MIS 3013 001
// Jan 31, 2024
// Alexandra Camarena
// 113568154

// string.Format()
// Format is function, is a machine, coffee maker
// string. function belongs to string
// Format () is a function call, press the start button

int age1;
double w1;
double m1;
double p1;
age1 = 21;
w1 = 128.6;// lbs
m1 = 20.6;
p1 = 0.15;

// \n is a special character
// \t tab key
string mesStr;
mesStr = string.Format($"The age is {age1}\nThe weight is {w1:F3}\nTThe money amount is {m1:C2}\tThe percentage is {p1:P4}");

Console.WriteLine(mesStr);