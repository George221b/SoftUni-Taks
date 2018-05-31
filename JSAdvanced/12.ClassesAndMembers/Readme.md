<h1>Exercises: Classes and Their Members</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/336/">https://judge.softuni.bg/Contests/336/</a>.</p>
<h2>1.&nbsp;&nbsp; Rectangle</h2>
<p>Write a JS <strong>class</strong> for a rectangle object. It needs to have a <strong>width</strong> (Number), <strong>height</strong> (Number) and <strong>color</strong> (String) properties, which are set from the constructor and a calcArea() method, that calculates and <strong>returns</strong> the rectangle&rsquo;s area.</p>
<h3>Input</h3>
<p>The constructor function will receive valid parameters.</p>
<h3>Output</h3>
<p>The calcArea() method should <strong>return</strong> a number.</p>
<p>Submit the class definition as is, <strong>without</strong> wrapping it in any function.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="907">
<p>Sample Input</p>
</td>
<td width="454">
<p>Output</p>
</td>
</tr>
<tr>
<td width="907">
<p>let rect = new Rectangle(4, 5, 'red');</p>
<p>console.log(rect.width);</p>
<p>console.log(rect.height);</p>
<p>console.log(rect.color);</p>
<p>console.log(rect.calcArea());</p>
</td>
<td width="454">
<p>&nbsp;</p>
<p>4</p>
<p>5</p>
<p>Red</p>
<p>20</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Person</h2>
<p>Write a JS <strong>class</strong> that represents a personal record. It has the following properties, all set from the constructor:</p>
<ul>
<li>firstName</li>
<li>lastName</li>
<li>age</li>
<li>email</li>
</ul>
<p>And a method toString(), which prints a summary of the information. See the example for formatting details.</p>
<h3>Input</h3>
<p>The constructor function will receive valid parameters.</p>
<h3>Output</h3>
<p>The toString()method should <strong>return</strong> a string.</p>
<p>Submit the class definition as is, <strong>without</strong> wrapping it in any function.</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>Sample Input</p>
</td>
</tr>
<tr>
<td width="1361">
<p>let person = new Person('Maria', 'Petrova', 22, 'mp@yahoo.com');</p>
<p>console.log(person);</p>
</td>
</tr>
<tr>
<td width="1361">
<p>Output</p>
</td>
</tr>
<tr>
<td width="1361">
<p>Maria Petrova (age: 22, email: mp@yahoo.com)</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Get Persons</h2>
<p>Write a JS function that returns an array of Person objects. Use the class from the previous task, create the following instances, and return them in an array:</p>
<p>For any empty cells, do not supply a parameter (call the constructor with less parameters).</p>
<h3>Input / Output</h3>
<p>There will be <strong>no input</strong>, the data is static and matches the table above. As <strong>output</strong>, <strong>return an array</strong> with Person <strong>instances</strong>.</p>
<p>Submit a function that returns the required output.</p>
<h2>4.&nbsp;&nbsp; Circle</h2>
<p>Write a JS <strong>class</strong> that represents a <strong>Circle</strong>. It has only one data property &ndash; it&rsquo;s <strong>radius</strong>, and it is set trough the <strong>constructor</strong>. The class needs to have <strong>getter</strong> and <strong>setter</strong> methods for its <strong>diameter</strong> &ndash; the setter needs to calculate the radius and change it and the getter needs to use the radius to calculate the diameter and return it.</p>
<p>The circle also has a getter area(), which calculates and <strong>returns</strong> its area.</p>
<h3>Input</h3>
<p>The constructor function and diameter setter will receive valid parameters.</p>
<h3>Output</h3>
<p>The diameter() and area() getters should <strong>return</strong> numbers.</p>
<p>Submit the class definition as is, <strong>without</strong> wrapping it in any function.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="907">
<p>Sample Input</p>
</td>
<td width="454">
<p>Output</p>
</td>
</tr>
<tr>
<td width="907">
<p>let c = new Circle(2);</p>
<p>console.log(`Radius: ${c.radius}`);</p>
<p>console.log(`Diameter: ${c.diameter}`);</p>
<p>console.log(`Area: ${c.area}`);</p>
<p>c.diameter = 1.6;</p>
<p>console.log(`Radius: ${c.radius}`);</p>
<p>console.log(`Diameter: ${c.diameter}`);</p>
<p>console.log(`Area: ${c.area}`);</p>
</td>
<td width="454">
<p>&nbsp;</p>
<p>2</p>
<p>4</p>
<p>12.566370614359172</p>
<p>&nbsp;</p>
<p>0.8</p>
<p>1.6</p>
<p>2.0106192982974678</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Point Distance</h2>
<p>Write a JS <strong>class</strong> that represents a <strong>Point</strong>. It has <strong>x</strong> and <strong>y</strong> coordinates as properties, that are set through the constructor, and a <strong>static method</strong> for finding the distance between two points, called distance().</p>
<h3>Input</h3>
<p>The distance() method should receive two <strong>Point</strong> objects as parameters.</p>
<h3>Output</h3>
<p>The distance() method should <strong>return</strong> a number, the distance between the two point parameters.</p>
<p>Submit the class definition as is, <strong>without</strong> wrapping it in any function.</p>
<h3>Examples</h3>
<table width="1361">
<tbody>
<tr>
<td width="907">
<p>Sample Input</p>
</td>
<td width="454">
<p>Output</p>
</td>
</tr>
<tr>
<td width="907">
<p>let p1 = new Point(5, 5);</p>
<p>let p2 = new Point(9, 8);</p>
<p>console.log(Point.distance(p1, p2));</p>
</td>
<td width="454">
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>5</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Cards</h2>
<p>You need to write an <strong>IIFE</strong> that results in an object containing two properties Card which is a class and Suits which is an object that will hold the possible suits for the cards.</p>
<p>The Suits object should have exactly these 4 properties:</p>
<ul>
<li><strong>SPADES</strong>: &spades;</li>
<li><strong>HEARTS</strong>: &hearts;</li>
<li><strong>DIAMONDS</strong>: &diams;</li>
<li><strong>CLUBS</strong>: &clubs;</li>
</ul>
<p>Where the key is <strong>SPADES</strong>, <strong>HEARTS</strong> e.t.c. and the value is the actual symbol &spades;, &hearts; and so on.</p>
<p>The Card class should allow for creating cards, each card has 2 properties <strong>face</strong> and <strong>suit</strong>. The <strong>valid</strong> faces are the following ["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"] any other are considered invalid.</p>
<p>The Card class should have setters and getters for the <strong>face</strong> and <strong>suit</strong> properties, when creating a card or setting a property validations should be performed, if an invalid face or a suit not in the Suits object is passed an Error should be <strong>thrown</strong>.</p>
<h3>Code Template</h3>
<p>You are required to write and submit an <strong>IIFE</strong> which results in an object containing the above-mentioned Card and Suits as properties. Here is an example template you can use:</p>
<table width="1329">
<tbody>
<tr>
<td width="1329">
<p>cards.js</p>
</td>
</tr>
<tr>
<td width="1329">
<p>(<strong>function</strong>(){</p>
<p><br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO</em></strong></p>
<p><strong><em><br /> &nbsp;&nbsp;&nbsp; </em></strong><strong>return </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Suits</strong>:<strong><em>Suits</em></strong>,<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Card</strong>:<strong><em>Card<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> }())</p>
</td>
</tr>
</tbody>
</table>
<h3>Screenshot</h3>
<p>An example usage should look like this:</p>
<p>&nbsp;</p>