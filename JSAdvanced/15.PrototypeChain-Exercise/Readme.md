<h1>Exercises: Classes, Inheritance, Unit Testing</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/341/">https://judge.softuni.bg/Contests/341/</a>.</p>
<h2>1.&nbsp;&nbsp; Balloons</h2>
<p>You have been tasked to create several classes for balloons.</p>
<p>Implement a class Balloon, which is initialized with a color (String) and gasWeight (Number). These two arguments should be <strong>public members</strong>.</p>
<p>Implement another class PartyBalloon, which inherits the Balloon class and is initialized with <strong>2 additional</strong> <strong>parameters</strong> &ndash; ribbonColor (String) and ribbonLength (Number).<br /> The PartyBalloon class should have a <strong>property</strong> ribbon, which is an <strong>object</strong> with <strong>color</strong> and <strong>length</strong> &ndash; the ones given upon initialization. The ribbon property should have a <strong>getter</strong>.</p>
<p>Implement another class BirthdayBalloon, which inherits the PartyBalloon class and is initialized with <strong>1 extra</strong> <strong>parameter</strong> &ndash; text (String). The text should be a property, and should have a <strong>getter</strong>.</p>
<h3>Screenshots</h3>
<p>First, we need to create a function, which will hold our classes, since we will return more than one and the Judge needs to know how to work with them. We create a simple function and we add the first class, the base class for all Balloons to it.</p>
<p>Now that we have our base class, we can create the first child class &ndash; the <strong>PartyBalloon</strong>, which extends the base Balloon class.</p>
<p>Upon inheriting the <strong>Balloon</strong> class, the constructor of the <strong>PartyBalloon</strong> class will require the use of the super() method, to initialize the <strong>Balloon</strong> base constructor.</p>
<p>We also need to add the <strong>ribbon object property</strong> in the constructor of the PartyBalloon class. This one is for you to do.</p>
<p>Now that we know how to basically inherit classes&hellip; Create the <strong>BirthdayBalloon</strong> class on your own. The <strong>BirthdayBalloon</strong> class should extend the <strong>PartyBalloon</strong> class, and should add an <strong>extra property</strong>. It is the same as the previous class.</p>
<p>Lastly, we need to return an object, containing all of our classes, so that the Judge can work with them.</p>
<p>Submit in the judge a <strong>function (NOT IIFE)</strong>, which holds all classes, and returns them as an object.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>2.&nbsp;&nbsp; People</h2>
<p>Define several JS classes, that represent a company&rsquo;s employee records. Every employee has a <strong>name</strong> and <strong>age</strong>, a <strong>salary</strong> and a list of <strong>tasks</strong>, while every position has specific properties not present in the others. Place all common functionality in a <strong>parent</strong> <strong>abstract</strong> class. Follow the diagram bellow:</p>
<p>Every position has different tasks. In addition to all common properties, the manager position has a <strong>dividend</strong> he can collect along with his salary.</p>
<p>All employees have a <strong>work</strong> function that when called cycles trough the list responsibilities for that position and prints the current one. When all tasks have been printed, the list starts over from the beginning. Employees can also <strong>collect salary</strong>, which outputs the amount, plus any <strong>bonuses</strong>.</p>
<p>Your program needs to expose a module, containing the three classes Junior, Senior and Manager. The properties name and age are set trough the constructor, while the salary and a manager&rsquo;s dividend are initially set to zero and can be changed later. The list of tasks is filled by each position. The resulting objects also expose the functions work() and collectSalary(). When work() is called, one of the following lines is printed on the console, depending on the current task in the list:</p>
<p>{employee name} is working on a simple task.</p>
<p>{employee name} is working on a complicated task.</p>
<p>{employee name} is taking time off work.</p>
<p>{employee name} is supervising junior workers.</p>
<p>{employee name} scheduled a meeting.</p>
<p>{employee name} is preparing a quarterly report.</p>
<p>And when collectSalary() is called, print the following:</p>
<p>{employee name} received {salary + bonuses} this month.</p>
<h3>Input / Output</h3>
<p>Any input will be passed as valid arguments, where applicable. Print any output that is required to the console as a string.</p>
<p>Submit your code as a revealing module, containing the three classes. Any definitions need to be named exactly as described above.</p>
<h3>Hints</h3>
<p>We should begin by creating a parent class, that will hold all properties, shared among the different positions. Looking at the problem description, we see the following structure for out parent object:</p>
<table width="1329">
<tbody>
<tr>
<td width="103">
<p>JavaScript</p>
</td>
</tr>
<tr>
<td width="103">
<p>{</p>
<p>&nbsp; age: Number,</p>
<p>&nbsp; name: String,</p>
<p>&nbsp; salary: Number,</p>
<p>&nbsp; tasks: [],</p>
<p>&nbsp; work: Function,</p>
<p>&nbsp; collectSalary: Function</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>Data variables will be part of the object attached to its local context with this inside the <strong>constructor</strong>. Any properties that need to be initialized at instantiation time are defined as function parameters. Functions are defined inside the class body.</p>
<p>The problem description requires that the parent class is abstract. To achieve this, we have to add a condition in the constructor which prevents its direct instantiation. Using the new.target keyword we can check whether the object was created from the abstract constructor or through a child class.</p>
<p>The work() function has to cycle trough the list of tasks and print the current one. The easiest way to do this is to shift the first element from the array and push it at the end.</p>
<p>&nbsp;</p>
<p>Printing the salary is pretty straightforward. However, since the manager has an additional bonus to his salary, it&rsquo;s best to get the whole sum with an internal function, that the manager can <strong>override</strong>.</p>
<p>Now any objects that inherit from Employee will have all of its properties as well as anything new that&rsquo;s defined in their declaration. To inherit (extend) a class, a new class is defined with the extends keyword after its name. They also have to call the parent constructor from their own constructor, so the prototype chain is established. For <strong>Junior</strong> and <strong>Senior</strong>, the only difference from the parent <strong>Employee</strong> is the elements inside the tasks array, since they can use the functions directly from the base class. Child classes will call the parent with any parameters that are needed and push their tasks directly to the array.</p>
<p>The <strong>Manager</strong> is not much different, with the exception that his constructor has to attach a dividend property that is initially set to zero. His definition also needs to override the getSalary() function we added to the base class earlier, so it includes the bonus.</p>
<p>After we&rsquo;re done with the definitions of all object constructors, we need to wrap them in a revealing module for use by other parts of our program without polluting the global namespace, and to be submitted to the Judge:</p>
<h2>3.&nbsp;&nbsp; Posts</h2>
<p>Your need to create several classes for <strong>Posts</strong>.</p>
<p>Implement a class Post, which is initialized with a title (String) and content (String). The 2 arguments should be <strong>public members</strong>.<br /> The Post class should also have toString() function which returns the following result:</p>
<p>&ldquo;Post: {postTitle}&rdquo;<br /> &ldquo;Content: {postContent}&rdquo;</p>
<p>Implement another class which is called SocialMediaPost, which inherits the Post class.<br /> The SocialMediaPost class should be initialized with <strong>2 additional arguments</strong> &ndash; likes (Number) and dislikes (Number). <br /> The SocialMediaPost class should hold an <strong>array of comments </strong>(Strings), and a function addComment(comment), which <strong>adds comments </strong>to <strong>that</strong> <strong>array</strong>.<br /> The SocialMediaPost class should extend the toString() function of the Post class, and should return the following result:</p>
<p>&ldquo;Post: {postTitle}&rdquo;<br /> &ldquo;Content: {postContent}&rdquo;<br /> &ldquo;Rating: {postLikes &ndash; postDislikes}&rdquo;<br /> &ldquo;Comments:&rdquo;<br /> &ldquo; * {comment1}&rdquo;<br /> &ldquo; * {comment2}&rdquo;<br /> . . .<br /> In case <strong>there are no comments</strong>, return information only about the <strong>title</strong>, <strong>content</strong> and <strong>rating</strong> of the <strong>post</strong>.</p>
<p>Implement another class which is called BlogPost, which inherits the Post class.<br /> The BlogPost class should be initialized with <strong>1 additional arguments</strong> &ndash; views (Number).<br /> The BlogPost class should hold a function view(), which <strong>increments</strong> the <strong>views</strong> of the object with <strong>1</strong>, every time it is called. The function should <strong>return the object</strong>, so that <strong>chaining is supported</strong>.<br /> The BlogPost class should extend the toString() function of the Post class, and should return the following result:</p>
<p>&ldquo;Post: {postTitle}&rdquo;<br /> &ldquo;Content: {postContent}&rdquo;<br /> &ldquo;Views: {postViews}&rdquo;</p>
<h3>Example</h3>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>posts.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p><strong>let </strong>post = <strong>new </strong>Post(<strong>"Post"</strong>, <strong>"Content"</strong>);<br /> <br /> <strong><em>console</em></strong>.log(post.toString());<br /> <br /> <em>// Post: Post<br /> // Content: Content<br /> <br /> </em><strong>let </strong>scm = <strong>new </strong>SocialMediaPost(<strong>"TestTitle"</strong>, <strong>"TestContent"</strong>, 25, 30);<br /> <br /> scm.addComment(<strong>"Good post"</strong>);<br /> scm.addComment(<strong>"Very good post"</strong>);<br /> scm.addComment(<strong>"Wow!"</strong>);<br /> <br /> <strong><em>console</em></strong>.log(scm.toString());<br /> <br /> <em>// Post: TestTitle<br /> // Content: TestContent<br /> // Rating: -5<br /> // Comments:<br /> //&nbsp; * Good post<br /> //&nbsp; * Very good post<br /> //&nbsp; * Wow!</em></p>
</td>
</tr>
</tbody>
</table>
<p>Submit in the judge a <strong>function (NOT IIFE)</strong>, which holds all classes, and returns them as an object.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>4.&nbsp;&nbsp; The Elemelons</h2>
<p>If Watermelons exist, Firemelons, Earthmelons and Airmelons should also exist. Create <strong>classes</strong> for <strong>The</strong> <strong>4 Elemelons</strong>.</p>
<p>Create an <strong>abstract class</strong> for the Elemelons. Name it Melon.<br /> The Melon class should be initialized with weight (Number), and melonSort (String). The 2 arguments should be <strong>public members</strong>.</p>
<p>Create classes Watermelon, Firemelon, Earthmelon, Airmelon. Each of them should <strong>inherit</strong> the <strong>abstract class</strong> Melon and its functionality. Aside from the abstract functionality, <strong>each</strong> of the <strong>Elemelons</strong> should have property elementIndex (Number), which is <strong>equal</strong> to its weight * the <strong>string length</strong> of its melonSort. The property should have only a <strong>getter</strong>.</p>
<p>All of the classes should hold a toString() function, which returns the following result for them:</p>
<p>&ldquo;Element: {Water/Fire/Earth/Air}&rdquo;<br /> &ldquo;Sort: {elemelonSort}&rdquo;<br /> &ldquo;Element Index: {elemelonElementIndex}&rdquo;</p>
<p>Create one more class which is called Melolemonmelon, which inherits <strong>one</strong> of the <strong>4 elemelons</strong>, <strong>regardless of which</strong>. <br /> The Melolemonmelon <strong>has no element</strong>, but it can <strong>morph</strong> into any of the others. Implement a function <strong>morph()</strong>, which <strong>changes the current element</strong> of the Melolemonmelon, <strong>each time</strong> it is called. <br /> Upon initialization, the <strong>initial element</strong> is <strong>Water</strong>. From then it should go in the following order: <strong>Fire, Earth, Air, Water, Fire&hellip; </strong>and so on.<br /> The toString() function should remain the same as its parent class.</p>
<p>&nbsp;</p>
<p>To create an abstract class you must make sure that that class cannot be instantiated directly. Put the following code in the constructor of the Melon class, before all else.</p>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>melon.js</p>
</td>
</tr>
<tr>
<td width="1329"><strong>class </strong>Melon {<br /> &nbsp;&nbsp;&nbsp; constructor(weight, melonSort) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>new</strong>.target === Melon) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong><strong>TypeError</strong>(<strong>"Abstract class cannot be instantiated directly"</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>//</em><strong><em>TODO: initialize weight and melonSort properties<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> }</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>scripts.js</p>
</td>
</tr>
<tr>
<td width="1329"><strong>let </strong>test = <strong>new </strong>Melon(100, <strong>"Test"</strong>);<br /> <em>//Throws error<br /> <br /> </em><strong>let </strong>watermelon = <strong>new </strong>Watermelon(12.5, <strong>"Kingsize"</strong>);<br /> <strong><em>console</em></strong>.log(watermelon.toString());<br /> <br /> <em>// Element: Water<br /> // Sort: Kingsize<br /> // Element Index: 100</em>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>Submit in the judge a <strong>function (NOT IIFE)</strong>, which holds all classes, and returns them as an object.</p>
<h2>5.&nbsp;&nbsp; *C# Console</h2>
<p>Write <strong>Mocha unit tests</strong> to verify the functionality of a JavaScript implementation of the C# Console <strong>class</strong>. If you've written some code in C#, you would know that you can format text using placeholders, an example would look like this:</p>
<p>Console.WriteLine("The sum of {0} and {1} is {2}", 3, 4, 7);</p>
<p>Here the first placeholder {0} is exchanged for the first parameter passed after the text template - 3. The second placeholder {1} for the second parameter - 4 and so on.</p>
<p>You will be provied with a class Console which has similar functionality to the C# one. The Console should have a static method writeLine which supports the following:</p>
<ul>
<li>writeLine(string) - if only a single argument is passed and it is a string, the function should simply return it.</li>
<li>writeLine(object) - if only a single parameter is passed and it is an object - return the <strong>JSON</strong> representation of the object.</li>
<li>writeLine(templateString, parameters) - It should support the following:
<ul>
<li>If multiple arguments are passed, but the first is not a string - throw a TypeError.</li>
<li>If the number of parameters does not correspond to the number of placeholders in the template string - throw a RangeError.</li>
<li>If the placeholders have indexes not withing the parameters range(for instance we have a placeholder {13} and only 5 params) throw a RangeError.</li>
<li>if multiple arguments are passed and the first is a string, find all placeholders from the string and <strong>exchange</strong> them with the supplied parameters.</li>
</ul>
</li>
</ul>
<p>Any cases not mentioned above, do not need to be checked.</p>
<h3>Constraints</h3>
<ul>
<li>All arguments in the writeLine(templateString, parameters) will be <strong>strings</strong>.</li>
<li>There will never be two placeholders with the same number.</li>
</ul>
<h3>JS Code</h3>
<p>To ease you in the process, you are provided with an implementation which meets all of the specification requirements for the Console object:</p>
<table width="1412">
<tbody>
<tr>
<td width="1412">
<p>specialConsole.js</p>
</td>
</tr>
<tr>
<td width="1412">
<p><strong>class </strong><strong><em>Console </em></strong>{<br /> <br /> &nbsp; <strong>static get </strong><em>placeholder</em>() {<br /> &nbsp;&nbsp;&nbsp; <strong>return </strong>/{\d+}/g;<br /> &nbsp; }<br /> <br /> &nbsp; <strong>static </strong><em>writeLine</em>() {<br /> &nbsp;&nbsp;&nbsp; <strong>let </strong>message = arguments[0];<br /> &nbsp;&nbsp;&nbsp; <strong>if </strong>(arguments.<strong>length </strong>=== 1) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>(message) === <strong>'object'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; message = <strong>JSON</strong>.stringify(message);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>message;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>else if </strong>(<strong>typeof</strong>(message) === <strong>'string'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>message;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>else </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(<strong>typeof </strong>(message) !== <strong>'string'</strong>) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong><strong>TypeError</strong>(<strong>"No string format given!"</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>else </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>let </strong>tokens = message.match(<strong>this</strong>.<em>placeholder</em>).sort(<strong>function </strong>(a, b) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; a = <strong><em>Number</em></strong>(a.substring(1, a.<strong>length </strong>- 1));<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; b = <strong><em>Number</em></strong>(b.substring(1, b.<strong>length </strong>- 1));<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>a - b;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; });<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(tokens.<strong>length </strong>!== (arguments.<strong>length </strong>- 1)) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong><strong>RangeError</strong>(<strong>"Incorrect amount of parameters given!"</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>else </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>for </strong>(<strong>let </strong>i = 0; i &lt; tokens.<strong>length</strong>; i++) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>let </strong>number = <strong><em>Number</em></strong>(tokens[i].substring(1, tokens[i].<strong>length </strong>- 1));<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>if </strong>(number !== i) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>throw new </strong><strong>RangeError</strong>(<strong>"Incorrect placeholders given!"</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>else </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; message = message.replace(tokens[i], arguments[i + 1])<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>return </strong>message;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; }<br /> };</p>
</td>
</tr>
</tbody>
</table>
<p>Your tests will be supplied a class named <strong>"Console"</strong> which contains the above-mentioned logic, all test cases you write should reference this variable. Submit in the judge your code containing Mocha tests testing the above functionality.</p>
<h2>6.&nbsp;&nbsp; *Computer</h2>
<p>You need to implement the class hierarchy for a computer business, here are the classes you should create and support:</p>
<ul>
<li>Keyboard - concrete class that contains:
<ul>
<li>manufacturer - string property for the name of the manufacturer.</li>
<li>responseTime - number property for the response time of the Keyboard.</li>
</ul>
</li>
<li>Monitor - concrete class that contains:
<ul>
<li>manufacturer - string property for the name of the manufacturer.</li>
<li>width - number property for the width of the screen.</li>
<li>height - number property for the height of the screen.</li>
</ul>
</li>
<li>Battery - concrete class that contains:
<ul>
<li>manufacturer - string property for the name of the manufacturer.</li>
<li>expectedLife - number property for the expected years of life of the Battery.</li>
</ul>
</li>
<li>Computer - <strong>abstract</strong> class that contains:
<ul>
<li>manufacturer - string property for the name of the manufacturer.</li>
<li>processorSpeed - a number property containing the speed of the processor in GHz.</li>
<li>ram - a number property containing the RAM of the computer in Gigabytes.</li>
<li>hardDiskSpace - a number property containing the hard disk space in Terabytes.</li>
</ul>
</li>
<li>Laptop - concrete class <strong>extending</strong> the Computer class that contains:
<ul>
<li>weight - a number property containing the weight of the Laptop in Kilograms.</li>
<li>color - a string property containing the color of the Laptop.</li>
<li>battery - an instance of the Battery class containing the Laptop's battery. There should be a getter and a setter for the property and validation that the passed in argument is actually an instance of the Battery class.</li>
</ul>
</li>
<li>Desktop - concrete class <strong>extending</strong> the Computer class that contains:
<ul>
<li>keyboard - an instance of the Keyboard class containing the Desktop PC's Keyboard. There should be a getter and a setter for the property and validation that the passed in argument is actually an instance of the Keyboard class.</li>
<li>monitor - an instance of the Monitor class containing the Desktop PC's Monitor. There should be a getter and a setter for the property and validation that the passed in argument is actually an instance of the Monitor class.</li>
</ul>
</li>
</ul>
<p>Attempting to instantiate an abstract class should throw an Error, attempting to pass an object that is not of the expected instance (ex. an object that is not an instance of Battery to the laptop as a battery) should throw a TypeError.</p>
<h3>Example</h3>
<table width="1388">
<tbody>
<tr>
<td width="1388">
<p>template.js</p>
</td>
</tr>
<tr>
<td width="1388">
<p><strong>function </strong><em>createComputerHierarchy</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>//</em><strong><em>TODO<br /> <br /> &nbsp;&nbsp;&nbsp; </em></strong><strong>return </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Battery</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Keyboard</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Monitor</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Computer</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Laptop</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>Desktop<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>You are asked to submit <strong>ONLY the function</strong> that returns an object containing the above mentioned classes.</p>
<h3>Bonus:</h3>
<p>In order to achieve a better code reuse, it's a good idea to have a base abstract class containing common information - check the classes, what common characteristics do they share that can be grouped in a common base class.</p>
<h2>7.&nbsp;&nbsp; **Mixins</h2>
<p>Using the classes from the last task, write two mixins (functions which attach some functionality to passed in classes' prototypes) to extend their functionality. You need to support the following mixins:</p>
<ul>
<li>computerQualityMixin(classToExtend) - a function that attaches the following functions to the prototype of the passed in class.
<ul>
<li>getQuality() - returns a number equal to the computer's<strong> (</strong>processorSpeed + RAM + hardDiskSpace) / 3.</li>
<li>isFast() - if processorSpeed&gt; (ram / 4) returns true, otherwise false.</li>
<li>isRoomy() - if hardDiskSpace &gt; Math.floor(ram * processorSpeed) returns true, otherwise false.</li>
</ul>
</li>
<li>styleMixin(classToExtend) - a function that attaches the following functions to the prototype of the passed in class:
<ul>
<li>isFullSet() - if the computer's manufacturer, keyboard's manufacturer and monitor's manufacturer all have the same name returns true, otherwise false.</li>
<li>isClassy() - if the computer battery's expectedLife is <strong>3 years or more</strong> and the computer's color is either <strong>"Silver"</strong> or <strong>"Black"</strong> and the computer's weight is <strong>less than 3 kilograms </strong>returns true, otherwise returns false.</li>
</ul>
</li>
</ul>
<h3>Example</h3>
<table width="1388">
<tbody>
<tr>
<td width="1388">
<p>template.js</p>
</td>
</tr>
<tr>
<td width="1388">
<p><strong>function </strong><em>createMixins</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>//</em><strong><em>TODO<br /> &nbsp;&nbsp;&nbsp; </em></strong><strong>return </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>computerQualityMixin</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>styleMixin<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>You are asked to submit <strong>ONLY the function</strong> that returns an object containing the above mentioned mixins.</p>