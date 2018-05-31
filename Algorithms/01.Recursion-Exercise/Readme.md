<h1>&nbsp;Exercises: Recursion</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/688/Recursion-Exercise">https://judge.softuni.bg/Contests/688/Recursion-Exercise</a>.</p>
<h2>1.&nbsp;&nbsp; Reverse Array</h2>
<p>Write a program that reverses and prints an array. Use <strong>recursion</strong>.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="228">
<p><strong>Input</strong></p>
</td>
<td width="252">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="228">
<p>1 2 3 4 5 6</p>
</td>
<td width="252">
<p>6 5 4 3 2 1</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Nested Loops To Recursion</h2>
<p>Write a program that simulates the execution of n nested loops <strong>from 1 to n</strong> which prints the values of all its iteration variables at any given time on a single line. <strong>Use recursion.</strong></p>
<h3>Examples</h3>
<table width="1401">
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="184">
<p><strong>Output</strong></p>
</td>
<td width="1033">
<p><strong>Solution with nested loops</strong></p>
<p><strong>(assuming n is positive)</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>2</p>
</td>
<td width="184">
<p>1 1</p>
<p>1 2</p>
<p>2 1</p>
<p>2 2</p>
</td>
<td width="1033">
<p>int n = 2;</p>
<p>&nbsp;</p>
<p>for (int i1 = 1; i1 &lt;= n; i1++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; for (int i2 = 1; i2 &lt;= n; i2++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine($"{i1} {i2}");</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="184">
<p>3</p>
</td>
<td width="184">
<p>1 1 1<br /> 1 1 2</p>
<p>1 1 3</p>
<p>1 2 1</p>
<p>1 2 2</p>
<p>&hellip;</p>
<p>3 2 3</p>
<p>3 3 1</p>
<p>3 3 2</p>
<p>3 3 3</p>
</td>
<td width="1033">
<p>int n = 3;</p>
<p>&nbsp;</p>
<p>for (int i1 = 1; i1 &lt;= n; i1++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; for (int i2 = 1; i2 &lt;= n; i2++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for (int i3 = 1; i3 &lt;= n; i3++)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine($"{i1} {i2} {i3}");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Combinations with Repetition</h2>
<p>Write a <strong>recursive</strong> program for generating and printing all combinations <strong>with duplicates</strong> of <strong>k </strong>elements from a set of <strong>n</strong> elements (k &lt;= n). In combinations, the <strong>order of elements doesn&rsquo;t matter</strong>, therefore (1 2) and (2 1) are the same combination, meaning that once you print/obtain (1 2), (2 1) is no longer valid.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="93">
<p><strong>Input</strong></p>
</td>
<td width="156">
<p><strong>Output</strong></p>
</td>
<td width="408">
<p><strong>Comments</strong></p>
</td>
<td width="743">
<p><strong>Solution with nested loops</strong></p>
</td>
</tr>
<tr>
<td width="93">
<p>3</p>
<p>2</p>
</td>
<td width="156">
<p>1 1</p>
<p>1 2</p>
<p>1 3</p>
<p>2 2</p>
<p>2 3</p>
<p>3 3</p>
</td>
<td width="408">
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; n=3 =&gt; we have a set of three elements {1, 2, 3}</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; k=2 =&gt; we select two elements out of the three each time</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Duplicates are allowed, meaning (1 1) is a valid combination.</p>
</td>
<td width="743">
<p>int n = 3;</p>
<p>int k = 2;</p>
<p>&nbsp;</p>
<p>// k == 2 =&gt; 2 nested for-loops</p>
<p>for (int i1 = 1; i1 &lt;= n; i1++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; for (int i2 = i1; i2 &lt;= n; i2++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine($"({i1} {i2})");</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="93">
<p>5</p>
<p>3</p>
</td>
<td width="156">
<p>1 1 1</p>
<p>1 1 2</p>
<p>1 1 3</p>
<p>1 1 4</p>
<p>1 1 5</p>
<p>1 2 2</p>
<p>&hellip;</p>
<p>3 5 5</p>
<p>4 4 4</p>
<p>4 4 5</p>
<p>4 5 5</p>
<p>5 5 5</p>
</td>
<td width="408">
<p>Select 3 elements out of 5 &ndash; {1, 2, 3, 4, 5}, a total of 35 combinations</p>
<p>(1 2 1) is not valid as it&rsquo;s the same as (1 1 2)</p>
</td>
<td width="743">
<p>int n = 5;</p>
<p>int k = 3;</p>
<p>&nbsp;</p>
<p>// k == 3 =&gt; 3 nested for-loops</p>
<p>for (int i1 = 1; i1 &lt;= n; i1++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; for (int i2 = i1; i2 &lt;= n; i2++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for (int i3 = i2; i3 &lt;= n; i3++)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine($"({i1} {i2} {i3})");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Tower of Hanoi</h2>
<p>Your task is to solve the famous <a href="https://en.wikipedia.org/wiki/Tower_of_Hanoi">Tower of Hanoi</a> puzzle using recursion.</p>
<p>In this problem, you have three rods (let&rsquo;s call them <strong>source</strong>, <strong>destination</strong> and <strong>spare</strong>). Initially, there are <strong>n disks</strong>, all placed on the source rod like in the picture below:</p>
<p>Your objective is to move all disks from the source rod to the destination rod. There are several <strong>rules</strong>:</p>
<ul>
<li>Only one disk can be moved at a time</li>
<li>Only the topmost disk on a rod can be moved</li>
<li>A disk can only be placed on top of a larger disk or on an empty rod</li>
</ul>
<h3>Step 1. Choose Appropriate Data Structures</h3>
<p>First, we need to decide how to model the problem in our program. The size of a disk can be represented by an <strong>integer number</strong> &ndash; the larger the number, the larger the disk.</p>
<p>How about the rods? According to the rules outlined above, we can either take a disk from the top of the rod or place a disk on top of it. This is an example of <strong>Last-In-First-Out (LIFO)</strong>, therefore, an appropriate structure to represent a rod would be <strong>Stack&lt;T&gt;</strong>. Since we&rsquo;ll be storing integers to represent the disks, we need <strong>Stack&lt;int&gt;</strong>, three of them to be precise &ndash; the <strong>source</strong>, the <strong>destination</strong> and the <strong>spare</strong>.</p>
<h3>Step 2. Setup</h3>
<p>Now that we have an idea what structures we&rsquo;ll be using, it&rsquo;s time for the initial setup. Before solving the puzzle for any number of disks, let&rsquo;s solve it with 3 and use hardcoded values. With 3 disks, it will be easier to keep track of the steps we&rsquo;ll take.</p>
<p>Initially, destination and spare are empty. In source, we need to have the numbers 1, 2, and 3, 1 being on top. We can use the <strong>Enumerable.Range</strong> method to obtain a sequence of integer numbers by providing a start value and count:</p>
<p>The constructor of Stack&lt;T&gt; allows us to pass a collection which will be used to create the stack. If we pass the variable <strong>range</strong> to the constructor, the largest disk will be on top, which is not what we want, so we can call the <strong>Reverse</strong> method from LINQ to reverse the numbers. We can omit the range variable altogether and pass the result directly like this:</p>
<h3>Step 3. Breaking down the Problem</h3>
<p>The Tower of Hanoi is solved by breaking it down to sub-problems. What we&rsquo;ll try to do is:</p>
<ul>
<li>Move all disks from source to destination starting with the largest (bottom disk)
<ol>
<li>If the bottom disk is equal to 1, we can simply move it</li>
<li>If the bottom disk is larger than 1
<ol>
<li>move all disks above it (starting from bottom &ndash; 1) to the spare rod</li>
<li>move the bottom disk to destination</li>
</ol>
</li>
</ol>
</li>
</ul>
<ul>
<li>finally, move the disks now on spare to destination (back on top of the bottom disk)</li>
</ul>
<p>In essence, steps <strong>1.b.i</strong> and <strong>1.b.iii </strong>repeat step 1, the only difference is that we&rsquo;re viewing different rods as source, destination and spare.</p>
<h3>Step 4. Solution</h3>
<p>Looking at step 3 above, it&rsquo;s apparent that we&rsquo;ll need a method which takes 4 arguments: the value of the bottom disk and the three rods (stacks).</p>
<p>We need an if-statement to check if bottomDisk == 1 (the bottom of our recursion). If that&rsquo;s the case, we&rsquo;ll pop an element from the source and push it to the destination. We can do it on a single line like this:</p>
<p>In the else clause, we need to do three things: 1) move all disks from bottomDisk - 1 from source to spare; 2) move the bottomDisk from source to destination; 3) move all disks from bottomDisk &ndash; 1 from spare to destination.</p>
<p>Complete the TODOs in the above picture, by calling MoveDisks recursively. If you did everything correctly, this should be it! Now it&rsquo;s time to test it.</p>
<h3>Step 5. Check Solution with Hardcoded Value</h3>
<p>In order to check this solution, let&rsquo;s make the three stacks static and declare an additional variable which will keep track of the current number of steps taken.</p>
<p>We&rsquo;ll need a method that prints the contents of all stacks, so we know which disk is where after each step:</p>
<p>Having the needed variables and the PrintRods method, we can modify the Main method like this:</p>
<p>In this case, we make the stacks static, because from within the MoveDisks method we don&rsquo;t know which stack is which. Since the stacks are now static, check for a collision of variable names and rename the parameters of MoveDisks if necessary; here, we&rsquo;ll just append Rod to distinguish the static stacks from the method parameters. Now, in both the if and the else clause of MoveDisks, we need to increment the steps counter, print which disk has been moved and print the contents of the three stacks like this:</p>
<p>The same is repeated in the else clause, the difference being the recursive calls we make before and after the move.</p>
<p>After running the program, you should now see each step of the process like this:</p>
<p>The Tower of Hanoi puzzle always takes exactly <strong>2<sup>n</sup> &ndash; 1 steps</strong>. With n == 3, all seven steps should be shown and in the end all disks should end up on the destination rod.</p>
<p>Using the output of your program and the debugger, follow each step and try to understand how this recursive algorithm works. It&rsquo;s much easier to see this with three disks.</p>
<h3>Step 6. Remove Hardcoded Values and Retest</h3>
<p>If everything went well and you&rsquo;re confident you&rsquo;ve understood the process, you can replace 3 with input from the user, just read a number from the console.</p>
<p>Test with several different values, and make sure that the steps taken are 2<sup>n</sup> &ndash; 1 and that all disks are successfully moved from source to destination.</p>
<p>Here is the full example with 3 disks:</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="377">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>3</p>
</td>
<td width="377">
<p>Source: 3, 2, 1</p>
<p>Destination:</p>
<p>Spare:</p>
<p>&nbsp;</p>
<p>Step #1: Moved disk 1</p>
<p>Source: 3, 2</p>
<p>Destination: 1</p>
<p>Spare:</p>
<p>&nbsp;</p>
<p>Step #2: Moved disk 2</p>
<p>Source: 3</p>
<p>Destination: 1</p>
<p>Spare: 2</p>
<p>&nbsp;</p>
<p>Step #3: Moved disk 1</p>
<p>Source: 3</p>
<p>Destination:</p>
<p>Spare: 2, 1</p>
<p>&nbsp;</p>
<p>Step #4: Moved disk 3</p>
<p>Source:</p>
<p>Destination: 3</p>
<p>Spare: 2, 1</p>
<p>&nbsp;</p>
<p>Step #5: Moved disk 1</p>
<p>Source: 1</p>
<p>Destination: 3</p>
<p>Spare: 2</p>
<p>&nbsp;</p>
<p>Step #6: Moved disk 2</p>
<p>Source: 1</p>
<p>Destination: 3, 2</p>
<p>Spare:</p>
<p>&nbsp;</p>
<p>Step #7: Moved disk 1</p>
<p>Source:</p>
<p>Destination: 3, 2, 1</p>
<p>Spare:</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Congratulations, you just solved The Tower of Hanoi puzzle using recursion!</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>5.&nbsp;&nbsp; Combinations without Repetition</h2>
<p>Modify the previous program to <strong>skip duplicates, e.g. (1 1) is not valid.</strong></p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="93">
<p><strong>Input</strong></p>
</td>
<td width="156">
<p><strong>Output</strong></p>
</td>
<td width="468">
<p><strong>Comments</strong></p>
</td>
<td width="683">
<p><strong>Solution with nested loops</strong></p>
</td>
</tr>
<tr>
<td width="93">
<p>3</p>
<p>2</p>
</td>
<td width="156">
<p>1 2</p>
<p>1 3</p>
<p>2 3</p>
</td>
<td width="468">
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; n=3 =&gt; we have a set of three elements {1, 2, 3}</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; k=2 =&gt; we select two elements out of the three each time</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Duplicates are not allowed, meaning (1 1) is not a valid combination.</p>
</td>
<td width="683">
<p>int n = 3;</p>
<p>int k = 2;</p>
<p>&nbsp;</p>
<p>// k == 2 =&gt; 2 nested for-loops</p>
<p>for (int i1 = 1; i1 &lt;= n; i1++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; for (int i2 = i1 + 1; i2 &lt;= n; i2++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine($"({i1} {i2})");</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
<tr>
<td width="93">
<p>5</p>
<p>3</p>
<p>&nbsp;</p>
</td>
<td width="156">
<p>1 2 3</p>
<p>1 2 4</p>
<p>1 2 5</p>
<p>1 3 4</p>
<p>1 3 5</p>
<p>1 4 5</p>
<p>2 3 4</p>
<p>2 3 5</p>
<p>2 4 5</p>
<p>3 4 5</p>
</td>
<td width="468">
<p>Select 3 elements out of 5 &ndash; {1, 2, 3, 4, 5}, a total of 10 combinations</p>
</td>
<td width="683">
<p>int n = 5;</p>
<p>int k = 3;</p>
<p>&nbsp;</p>
<p>// k == 3 =&gt; 3 nested for-loops</p>
<p>for (int i1 = 1; i1 &lt;= n; i1++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; for (int i2 = i1 + 1; i2 &lt;= n; i2++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for (int i3 = i2 + 1; i3 &lt;= n; i3++)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine($"({i1} {i2} {i3})");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Connected Areas in a Matrix</h2>
<p>Let&rsquo;s define a <strong>connected area</strong> in a matrix as an area of cells in which there is a<strong> path between every two cells</strong>.</p>
<p>Write a program to find <strong>all</strong> connected areas in a matrix.</p>
<p>On the console, print the <strong>total number of areas found</strong>, and on a separate line some info about each of the areas &ndash; its position (top-left corner) and size.</p>
<p><strong>Order</strong> the areas by size (in descending order) so that the <strong>largest area is printed first</strong>. If several areas have the same size, order them <strong>by their position</strong>, first by the row, then by the column of the top-left corner. So, if there are two connected areas with the same size, the one which is above and/or to the left of the other will be printed first.</p>
<p>On the first line, you will get the <strong>number of rows</strong>.</p>
<p>On the second line, you will get the <strong>number of columns</strong>.</p>
<p>The rest of the input will be the <strong>actual matrix</strong>.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="1245">
<tbody>
<tr>
<td width="645">
<p><strong>Example Layout</strong></p>
</td>
<td width="600">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="645">
<p>4</p>
<p>9</p>
<table>
<tbody>
<tr>
<td width="41">
<p>1</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>2</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>3</p>
</td>
</tr>
<tr>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>-</p>
</td>
</tr>
<tr>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>-</p>
</td>
</tr>
<tr>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>*</p>
</td>
<td width="41">
<p>-</p>
</td>
<td width="41">
<p>-</p>
</td>
</tr>
</tbody>
</table>
</td>
<td width="600">
<p>Total areas found: 3</p>
<p>Area #1 at (0, 0), size: 13</p>
<p>Area #2 at (0, 4), size: 10</p>
<p>Area #3 at (0, 8), size: 5</p>
</td>
</tr>
<tr>
<td width="645">
<p>5</p>
<p>10</p>
<table>
<tbody>
<tr>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>1</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>3</p>
</td>
<td width="45">
<p>&nbsp;</p>
</td>
<td width="51">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>2</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="45">
<p>&nbsp;</p>
</td>
<td width="51">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="45">
<p>*</p>
</td>
<td width="51">
<p>*</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>4</p>
</td>
<td width="45">
<p>&nbsp;</p>
</td>
<td width="51">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="45">
<p>&nbsp;</p>
</td>
<td width="51">
<p>&nbsp;</p>
</td>
<td width="48">
<p>*</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
<td width="48">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
</td>
<td width="600">
<p>Total areas found: 4</p>
<p>Area #1 at (0, 1), size: 10</p>
<p>Area #2 at (0, 8), size: 10</p>
<p>Area #3 at (0, 4), size: 6</p>
<p>Area #4 at (3, 4), size: 6</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create a method to find the first traversable cell which hasn&rsquo;t been visited. This would be the top-left corner of a connected area. If there is no such cell, this means all areas have been found.</li>
<li>You can create a class to hold info about a connected area (its position and size). Additionally, you can implement IComparable and store all areas found in a SortedSet.</li>
</ul>