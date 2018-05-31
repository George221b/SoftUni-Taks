<h1>Homework: Combinatorial Algorithms</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/opencourses/algorithms">"Algortihms" course @ Software University</a>. Submit your solutions to the automated <a href="https://judge.softuni.bg/Contests/695/Combinatorial-Algoritms">Judge</a> system.</p>
<h2>1.&nbsp;&nbsp; Iterative Permutations without Repetitions</h2>
<p>Write a <strong>non-recursive algorithm</strong> to generate all permutations without repetition. There shouldn&rsquo;t be any recursive calls in your program (only loops). You may use the judge system to check whether your solution is correct.</p>
<p>Hint: <a href="http://www.quickperm.org/">http://www.quickperm.org/</a></p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B C</p>
</td>
<td width="125">
<p>A B C</p>
<p>A C B</p>
<p>B A C</p>
<p>B C A</p>
<p>C B A</p>
<p>C A B</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Iterative Combinations without Repetition</h2>
<p>Write an <strong>iterative</strong> program to generate all combinations (without repetition) of <strong>k</strong> elements from a set of <strong>n</strong> elements. Remember, in combinations, the order of elements doesn&rsquo;t matter &ndash; (1 2) and (2 1) are considered the same combination. You are not allowed to use recursion. Search the Internet for a suitable algorithm.</p>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B C</p>
<p>2</p>
</td>
<td width="125">
<p>A B</p>
<p>A C</p>
<p>B C</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Iterative Permutations with Repetition</h2>
<h3>Write a program to generate all permutations with repetition of a given multi-set. Ensure your program efficiently avoids duplicated permutations. Test it with { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }.</h3>
<h3>Examples</h3>
<table width="244">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>A B B</p>
</td>
<td width="125">
<p>A B B</p>
<p>B A B</p>
<p>B B A</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; * Snakes</h2>
<p>A <strong>snake</strong> is a sequence of several square blocks, attached one after another. A snake starts with a block at some position and continues with another block to the left, right, up or down, then again with another block to the left, right, up or down, etc. A snake of size <strong>N</strong> consists of a sequence of <strong>N</strong> blocks and is not allowed to cross itself.</p>
<p>You are given a number <strong>N</strong> and you should find all possible snakes of <strong>N</strong> blocks, represented as sequences of moves denoted as: <strong>S</strong> (start), <strong>L</strong> (move left), <strong>R</strong> (move right), <strong>U</strong> (move up) and <strong>D</strong> (move down). Examples (for N = 1, 2, 3, 4, and 5):</p>
<p>Note: some figures could look visually the same but represent different snakes, e.g. <strong>SRRDL</strong> and <strong>SRDRU</strong>.</p>
<p>Some snakes (sequences of blocks) are the same and should be printed only once. If after a number of rotations and/or flips two snakes are equal they are considered the same and should be printed only once. For example the snakes <strong>SRRD</strong>, <strong>SRRU</strong>, <strong>SLLD, SLLU</strong>,<strong> SRUU</strong> and <strong>SUUR</strong> are the same:</p>
<p>Not all forms consisting of N blocks are snakes of size N. Examples of non-snake forms:</p>
<p>&nbsp;</p>
<p><strong>Note: When generating the snakes, there may be different correct answers. When testing your solution, priority should be as follows: R -&gt; D -&gt; L -&gt; U. The visual example above for n = 5 does NOT follow this priority.</strong></p>
<h3>Input</h3>
<ul>
<li>The input should be read from the console.</li>
<li>It will contain an integer number <strong>N</strong> in the range [1 ... 15].</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console. It should consist of a variable number of lines:</li>
<li>Each line should hold a snake represented as a sequence of moves.</li>
<li>On the last line, print the number of snakes in format: <strong>"Snakes count = {0}"</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>Allowed working time for your program: 10 seconds. Allowed memory: 512 MB.</li>
</ul>
<h3>Examples</h3>
<table width="1425">
<tbody>
<tr>
<td width="105">
<p><strong>Input</strong></p>
</td>
<td width="360">
<p><strong>Sample Output</strong></p>
</td>
<td width="960">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="105">
<p>2</p>
</td>
<td width="360">
<p>SR</p>
<p>Snakes count = 1</p>
</td>
<td width="960">
<p>Note that <strong>SU</strong>, <strong>SL</strong> and <strong>SD</strong> are also correct outputs. However, SR takes precedence because R has priority over all other directions.</p>
</td>
</tr>
<tr>
<td width="105">
<p>4</p>
</td>
<td width="360">
<p>SRRR</p>
<p>SRRD</p>
<p>SRDR</p>
<p>SRDL</p>
<p>Snakes count = 4</p>
</td>
<td width="960">
<p>Note that there are many other correct outputs for N = 4, but this is the expected output according to the priority of directions (right, down, left, up).</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; * Cubes</h2>
<p>You are given 12 sticks of the same length, each colored with a color in the range [1 &hellip; 4]. Write a program to find the number of different cubes that can be built using these sticks. Note that two cubes are equal if a sequence of rotations exists that transforms the first cube to the second. For example, the first two cubes below are equal (after two rotations) but are different from the third cube:</p>
<p>Print on the console the number of different cubes that can be obtained using the sticks provided.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console. It will consist of a single line that contains 12 numbers in the range [1 &hellip; 4] separated by spaces.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console. It should consist of 1 line:</li>
<li>On the only output line print a single integer number, representing the number of cubes that can be created using the provided sticks.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>Allowed working time for your program: 0.75 seconds. Allowed memory: 128 MB.</li>
</ul>
<h3>Examples</h3>
<table width="718">
<tbody>
<tr>
<td width="430">
<p><strong>Input</strong></p>
</td>
<td width="288">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="430">
<p>1 2 2 2 2 2 2 2 2 2 2 2</p>
</td>
<td width="288">
<p>1</p>
</td>
</tr>
<tr>
<td width="430">
<p>1 1 2 2 2 3 3 3 3 3 3 3</p>
</td>
<td width="288">
<p>340</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>