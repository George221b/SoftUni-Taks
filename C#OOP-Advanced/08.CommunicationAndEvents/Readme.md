<h1>Exercises: Communication and Events</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/java-basics-oop">"C# OOP Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Event Implementation</h2>
<p>Create a class <strong>Dispatcher</strong> with a property <strong>name</strong> and a class <strong>Handler</strong>. Create a public delegate called <strong>NameChangeEventHandler</strong> with return type void in the Namespace of the Dispatcher (but outside of the Dispatcher class) and an <strong>event</strong> (a field of the delegate&rsquo;s type) inside the <strong>Dispatcher</strong> class called <strong>NameChange</strong>. Create a class NameChangeEventArgs which inherits the EventArgs class and has a property - <strong>name</strong> which is received through the constructor and has a private setter and a public getter. Create also a method called <strong>OnNameChange(NameChangeEventArgs args)</strong> in the <strong>Dispatcher</strong> - this is the method that should be called to fire the event. In the setter for the Dispatcher&rsquo;s name, call the <strong>OnNameChange</strong> method and pass it an object of NameChangeEventArgs type with the new value for the name passed to the setter.</p>
<p>Implement a method <strong>OnDispatcherNameChange(object sender, NameChangeEventArgs args)</strong> in the Handler class, the implementation should write on the console <strong>&ldquo;Dispatcher&rsquo;s name changed to &lt;newName&gt;&rdquo;</strong>. At the start of your program create a new Dispatcher and Handler, then add the Handler&rsquo;s <strong>OnDispatcherNameChange</strong> method to the <strong>NameChange event</strong> in the Dispatcher.</p>
<h3>Input</h3>
<p>From the console you will receive lines containing a name until the <strong>&ldquo;End&rdquo;</strong> command is received. For each name change the dispatcher&rsquo;s name to it. Everytime the Dispatcher&rsquo;s name is changed, you should fire an event to all observers.</p>
<h3>&nbsp;Output</h3>
<p>For each name change of the dispatcher the handler should print <strong>&ldquo;Dispatcher's name changed to &lt;newName&gt;.&rdquo;</strong> on the console.</p>
<h3>Constraints</h3>
<ul>
<li>Names will contain only alphanumerical characters.</li>
<li>The number of commands will be a positive integer between <strong>[1&hellip;100]</strong>.</li>
<li>The last command will always be the only <strong>&ldquo;End&rdquo;</strong></li>
</ul>
<h3>Examples</h3>
<table width="1390">
<tbody>
<tr>
<td width="521">
<p><strong>Input</strong></p>
</td>
<td width="869">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="521">
<p>Pesho</p>
<p>Gosho</p>
<p>Stefan</p>
<p>End</p>
</td>
<td width="869">
<p>Dispatcher's name changed to Pesho.</p>
<p>Dispatcher's name changed to Gosho.</p>
<p>Dispatcher's name changed to Stefan.</p>
</td>
</tr>
<tr>
<td width="521">
<p>Prakash</p>
<p>Stamat</p>
<p>MuadDib</p>
<p>Ivan</p>
<p>Joro</p>
<p>End</p>
</td>
<td width="869">
<p>Dispatcher's name changed to Prakash.</p>
<p>Dispatcher's name changed to Stamat.</p>
<p>Dispatcher's name changed to MuadDib.</p>
<p>Dispatcher's name changed to Ivan.</p>
<p>Dispatcher's name changed to Joro.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; King&rsquo;s Gambit</h2>
<p>Implement 3 classes - <strong>King, Footman</strong> and <strong>Royal Guard</strong>. All of them have a <strong>name </strong>(names are <strong>unique</strong> there will never be two units with the same name), Footmen and Royal Guards can also be <strong>killed</strong> (killed units are removed from the program), while the king is <strong>attackable</strong> - should have a method to respond to attacks. Whenever the king is attacked, he should print to the console &ldquo;<strong>King &lt;kingName&gt; is under attack!</strong>&rdquo;and all <strong>alive</strong> Footmen and Royal guards should respond to the attack:</p>
<ul>
<li><strong>Footman</strong> respond by writing to the console <strong>&ldquo;Footman &lt;footmanName&gt; is panicking!&rdquo;</strong>.</li>
<li><strong>Royal Guards</strong> instead write <strong>&ldquo;Royal Guard &lt;guardName&gt; is defending</strong><strong>!&rdquo;</strong>.</li>
</ul>
<h3>Input</h3>
<p>On the first line of the console you will receive a single string - the name of the <strong>king</strong>. On the second line you will receive the names of his <strong>Royal Guards</strong> separated by spaces. On the third the names of his <strong>Footmen</strong> separated by spaces. On the next lines until the command <strong>&ldquo;End&rdquo;</strong> is received, you will receive commands in one of the following format:</p>
<ul>
<li><strong>&ldquo;Attack King&rdquo; </strong>- calls the king&rsquo;s respond to attack method.</li>
<li><strong>&ldquo;Kill &lt;name&gt;&rdquo; </strong>- the Footman or Royal Guard with the given name is killed.</li>
</ul>
<h3>Output</h3>
<p>Whenever the king is attacked you should print on the console &ldquo;<strong>King &lt;kingName&gt; is under attack!</strong>&rdquo; and each <strong>living</strong> Footman and Royal Guard should print <strong>their response message</strong> - first all Royal Guards should respond (in the order that they were received from the input) and then all Footmen should respond (in the order that they were received from the input). Every message should be printed on a new line.</p>
<h3>Constraints</h3>
<ul>
<li>Names will contain only alphanumerical characters.</li>
<li>There will <strong>always</strong> be a <strong>king</strong> and at least <strong>one Footman</strong> and <strong>one Royal Guard</strong>.</li>
<li>The king <strong>cannot be killed</strong> - there will never be a kill command for the king.</li>
<li>Kill commands will be received only for living soldiers.</li>
<li>All commands received will be valid commands in the formats described.</li>
<li>The number of commands will be a positive integer between <strong>[1&hellip;100]</strong>.</li>
<li>The last command will always be the only <strong>&ldquo;End&rdquo;</strong></li>
</ul>
<h3>Examples</h3>
<table width="1390">
<tbody>
<tr>
<td width="521">
<p><strong>Input</strong></p>
</td>
<td width="869">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="521">
<p>Pesho</p>
<p>Krivogled Ruboglav</p>
<p>Gosho Pencho Stamat</p>
<p>Attack King</p>
<p>End</p>
</td>
<td width="869">
<p>King Pesho is under attack!</p>
<p>Royal Guard Krivogled is defending!</p>
<p>Royal Guard Ruboglav is defending!</p>
<p>Footman Gosho is panicking!</p>
<p>Footman Pencho is panicking!</p>
<p>Footman Stamat is panicking!</p>
</td>
</tr>
<tr>
<td width="521">
<p>HenryVIII</p>
<p>Thomas Oliver</p>
<p>Mark</p>
<p>Kill Oliver</p>
<p>Attack King</p>
<p>Kill Thomas</p>
<p>Kill Mark</p>
<p>Attack King</p>
<p>End</p>
</td>
<td width="869">
<p>King HenryVIII is under attack!</p>
<p>Royal Guard Thomas is defending!</p>
<p>Footman Mark is panicking!</p>
<p>King HenryVIII is under attack!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dependency Inversion</h2>
<p>You are given a skeleton of a simple project. The project contains a class Primitive Calculator which supports two methods - <strong>ChangeStrategy(char @operator)</strong> and <strong>PerformCalculation(int firstOperand, int secondOperand)</strong>. The <strong>PerformCalculation</strong> method should perform a mathematical operation on the two operands based on the Primitive Calculator&rsquo;s current Strategy and the <strong>ChangeStrategy</strong> should change the calculator&rsquo;s current Strategy. Currently the calculator supports only adding and subtracting strategies, think how to refactor the <strong>ChangeStrategy </strong>and <strong>PerformCalculation</strong> method to allow the Primitive Calculator to support any strategy. Add functionality to the Primitive calculator to support multiplying and dividing of elements.</p>
<p>The calculator should start by <strong>default</strong> in <strong>addition</strong> mode. Currently the <strong>ChangeStrategy </strong>method can switch only between 2 Strategies based on a character received by the method. The currently supported strategies are:</p>
<ul>
<li><strong>&ldquo;+&rdquo;</strong> for addition</li>
<li><strong>&ldquo;-&ldquo;</strong> for subtraction</li>
</ul>
<h3>Input</h3>
<p>From the console you will receive lines in one of the following formats until the command <strong>&ldquo;End&rdquo;</strong> is received:</p>
<ul>
<li><strong>&ldquo;&lt;number&gt; &lt;number&gt;&rdquo;</strong> - perform calculation on the current numbers based on the current mode of the calculator.</li>
<li><strong>&ldquo;mode &lt;operator&gt;&rdquo;</strong> - changes the mode of the calculator to the specified one.</li>
</ul>
<h3>Output</h3>
<p>Print the results of the calculation of all number lines - each result on a new line.</p>
<h3>Constraints</h3>
<ul>
<li>You are allowed to refactor the Primitive Calculator class, but you&rsquo;re <strong>NOT</strong> allowed to add additional methods to it like Addition method, Subtraction method and so on.</li>
<li>The <strong>operators </strong>received from the console will always be valid ones specified in the calculator modes section.</li>
<li>The <strong>result of the calculations</strong> should also be an <strong>integer</strong>.</li>
<li>There will <strong>never</strong> be a 0 divisor.</li>
<li>The last command will always be the <strong>&ldquo;End&rdquo;</strong></li>
</ul>
<h3>Examples</h3>
<table width="1390">
<tbody>
<tr>
<td width="521">
<p><strong>Input</strong></p>
</td>
<td width="869">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="521">
<p>10 15</p>
<p>mode /</p>
<p>20 5</p>
<p>17 7</p>
<p>mode -</p>
<p>30 31</p>
<p>End</p>
</td>
<td width="869">
<p>25</p>
<p>4</p>
<p>2</p>
<p>-1</p>
</td>
</tr>
<tr>
<td width="521">
<p>mode *</p>
<p>1 1</p>
<p>3 21</p>
<p>-5 -6</p>
<p>mode -</p>
<p>-30 -50</p>
<p>mode /</p>
<p>-28 4</p>
<p>mode +</p>
<p>1 10</p>
<p>End</p>
</td>
<td width="869">
<p>1</p>
<p>63</p>
<p>30</p>
<p>20</p>
<p>-7</p>
<p>11</p>
</td>
</tr>
</tbody>
</table>