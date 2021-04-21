<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson14.aspx.cs" Inherits="JavaScript_Part1.Lesson14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 14 - Functions

    </title>
    <script type="text/javascript">
        

        function add1(x, y) { //no return types in this function
            //return x + y;
        }

        var addition = add(3, 7);
        document.write('addition: ', addition, "<br/>");

        addition = add(4, 5, 7, 8); //supplying extra values
        document.write('addition: ', addition, "<br/>");

        addition = add1(2, 5);
        document.write('addition: ', addition, "<br/>"); // this will be undefined
        document.write("<br/>");

        //different ways of defining a method
        //1.    Defining a JavaScript function using the 'function' declaration, like the add(x, y)
                // 1.1 Here, in this case, we can define the function before or after the function call.
                //  JavaScript at runtime, finds where the function is defined.
                //  By default, Javascript will move all the function declaration to the top
                //  of the current scope. This is called method hoisting.

        //2.    Defining a JavaScript function using the function expression.
                //A function expression allows us to define a function using an expression
                //three different ways of defining a function using the above

                //1. Anonymous Funciton:
                    // function has no name, check out the below example.
                    // function defined using function expression can not be hoisted.

        //multiplication = multiply(2, 5); // this will not work, as it is not hoistable
        var multiply = function (firstNum, secNum) { return firstNum * secNum; };
        multiplication = multiply(2, 5);
        document.write('multiplication: ', multiplication, "<br/>"); 
        document.write("<br/>");

                //2. Named Function Expression:
                //     This is similar to annonymous function expression.
                //     The only difference is instead of assigning the variable to an
                //     annonymous function, we are assigning it to a named fucntion. Example below:
        var factorial = function factorialit(num) {
            if (num == 1 || num == 0)
                return 1;
            return num * factorialit(num - 1);
        };
        myfactorial = factorial(5);
        //myfactorial = factorialit(5); // this won't work because factorialit is accessible only inside the factorialit function
        document.write('factorial: ', myfactorial, "<br/>");
        document.write("<br/>");


                //3. Self invoking function expression
                //      these are also called immediately invoked function expression 
                //      self executing  annonymous function
                //      self invoking annonymous function
                //      example below:

        var iife_factorial = (function factorialme(num) {
            if (num == 1 || num == 0)
                return 1;
            return num * factorialme(num - 1);
        }(7) );
        
        document.write('iife -factorial: ', iife_factorial, "<br/>");
        document.write("<br/>");




        //the below add method/function is being hoisted.
        function add(x, y) { //the function call is happening before the function definition.
            return x + y; 
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
