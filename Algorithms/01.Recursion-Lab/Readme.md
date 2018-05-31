<h1>Lab: Recursion</h1>
<p>This document defines the <strong>in-class exercises</strong> (lab) for the <a href="https://softuni.bg/trainings/1194/Algorithms-September-2015">"Algortihms" course @ Software University</a>.</p>
<h1>Part I - Recursion</h1>
<h2>1.&nbsp;&nbsp; Recursive Array Sum</h2>
<p>Write a program that finds the sum of all elements in an integer array. Use <strong>recursion</strong>.</p>
<p><strong>Note</strong>: In practice recursion should not be used here (instead use an <strong>iterative solution</strong>), this is just an exercise.</p>
<h3>Examples</h3>
<table width="277">
<tbody>
<tr>
<td width="152">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>1 2 3 4</p>
</td>
<td width="125">
<p>10</p>
</td>
</tr>
<tr>
<td width="152">
<p>-1 0 1</p>
</td>
<td width="125">
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Write a <strong>recursive</strong> method. It will take as arguments the <strong>input array</strong> and the <strong>current index</strong>.</p>
<ul>
<li>The method should return the <strong>current element</strong> + the <strong>sum of all next elements </strong>(obtained by recursively calling it).</li>
<li>The recursion should stop when there are no more elements in the array.</li>
</ul>
<h2>2.&nbsp;&nbsp; Recursive Factorial</h2>
<p>Write a program that finds the factorial of a given number. Use <strong>recursion</strong>.</p>
<p><strong>Note</strong>: In practice recursion should not be used here (instead use an <strong>iterative solution</strong>), this is just an exercise.</p>
<h3>Examples</h3>
<table width="254">
<tbody>
<tr>
<td width="103">
<p><strong>Input</strong></p>
</td>
<td width="152">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p>5</p>
</td>
<td width="152">
<p>120</p>
</td>
</tr>
<tr>
<td width="103">
<p>10</p>
</td>
<td width="152">
<p>3628800</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Write a <strong>recursive</strong> method. It will take as arguments an integer number.</p>
<ul>
<li>The method should return the <strong>current element</strong> * the <strong>result of calculating factorial of current element - 1 </strong>(obtained by recursively calling it).</li>
<li>The recursion should stop when there are no more elements in the array.</li>
</ul>
<h2>3.&nbsp;&nbsp; Recursive Drawing</h2>
<p>Write a program that draws the figure below depending on n. Use <strong>recursion</strong>.</p>
<h3>Examples</h3>
<table width="227">
<tbody>
<tr>
<td width="103">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p>2</p>
</td>
<td width="125">
<p>**</p>
<p>*</p>
<p>#</p>
<p>##</p>
</td>
</tr>
<tr>
<td width="103">
<p>5</p>
</td>
<td width="125">
<p>*****</p>
<p>****</p>
<p>***</p>
<p>**</p>
<p>*</p>
<p>#</p>
<p>##</p>
<p>###</p>
<p>####</p>
<p>#####</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Set the bottom of the recursion</p>
<p>Define pre- and post- recursive behavior</p>
<h2>4.&nbsp;&nbsp; Generating 0/1 Vectors</h2>
<p>Generate all n-bit vectors of zeroes and ones in lexicographic order.</p>
<h3>Examples</h3>
<table width="227">
<tbody>
<tr>
<td width="103">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p>3</p>
</td>
<td width="125">
<p>000</p>
<p>001</p>
<p>010</p>
<p>011</p>
<p>100</p>
<p>101</p>
<p>110</p>
<p>111</p>
</td>
</tr>
<tr>
<td width="103">
<p>5</p>
</td>
<td width="125">
<p>00000</p>
<p>00001</p>
<p>00010</p>
<p>&hellip;</p>
<p>11110</p>
<p>11111</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>The method should receive as parameters the array which will be our vector and a current index</p>
<p>Bottom of recursion should be when the index is outside of the vector</p>
<p>To generate all combinations, create a for loop with a recursive call</p>
<h2>5.&nbsp;&nbsp; Generating Combinations</h2>
<p>Generate all <strong>n choose k</strong> combinations. Read the set of elements, then number of elements to choose.</p>
<h3>Examples</h3>
<table width="309">
<tbody>
<tr>
<td width="184">
<p><strong>Input</strong></p>
</td>
<td width="125">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="184">
<p>1 2 3 4</p>
<p>2</p>
</td>
<td width="125">
<p>1 2</p>
<p>1 3</p>
<p>1 4</p>
<p>2 3</p>
<p>2 4</p>
<p>3 4</p>
</td>
</tr>
<tr>
<td width="184">
<p>1 2 3 4 5</p>
<p>3</p>
</td>
<td width="125">
<p>1 2 3</p>
<p>1 2 4</p>
<p>1 2 5</p>
<p>&hellip;</p>
<p>3 4 5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>The method should receive the following parameters</p>
<p>Set the bottom of the recursion</p>
<p>Loop through all possible picks for a given index of the vector</p>
<h1>Part II - 8 Queens Puzzle</h1>
<p>In this lab we will implement a recursive algorithm to solve the <strong>"8 Queens" puzzle</strong>. Our goal is to write a program to <strong>find all possible placements of 8 chess queens</strong> on a chessboard, so that no two queens can attack each other (on a row, column or diagonal).</p>
<h3>Examples</h3>
<table width="545">
<tbody>
<tr>
<td width="200">
<p><strong>Input</strong></p>
</td>
<td width="345">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="200">
<p><em>(no input)</em></p>
</td>
<td width="345">
<p>* - - - - - - -</p>
<p>- - - - * - - -</p>
<p>- - - - - - - *</p>
<p>- - - - - * - -</p>
<p>- - * - - - - -</p>
<p>- - - - - - * -</p>
<p>- * - - - - - -</p>
<p>- - - * - - - -</p>
<p>&nbsp;</p>
<p>* - - - - - - -</p>
<p>- - - - - * - -</p>
<p>- - - - - - - *</p>
<p>- - * - - - - -</p>
<p>- - - - - - * -</p>
<p>- - - * - - - -</p>
<p>- * - - - - - -</p>
<p>- - - - * - - -</p>
<p>&nbsp;</p>
<p>&hellip;</p>
<p>&nbsp;</p>
<p><em>(90 solutions more)</em></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>1.&nbsp;&nbsp; Learn about the "8 Queens" Puzzle</h2>
<p>Learn about the "8 Queens" puzzle, e.g. from Wikipedia: <a href="http://en.wikipedia.org/wiki/Eight_queens_puzzle">http://en.wikipedia.org/wiki/Eight_queens_puzzle</a>.</p>
<h2>2.&nbsp;&nbsp; Define a Data Structure to Hold the Chessboard</h2>
<p>First, let&rsquo;s define a data structure to hold the <strong>chessboard</strong>. It should consist of 8 x 8 cells, each either occupied by a queen or empty. Let&rsquo;s also define the size of the chessboard as a constant:</p>
<h2>3.&nbsp;&nbsp; Define a Data Structure to Hold the Attacked Positions</h2>
<p>We need to <strong>hold the attacked positions</strong> in some data structure. At any moment during the execution of the program, we need to know <strong>whether a certain</strong> <strong>position</strong> <strong>{row, col} is under attack</strong> by a queen or not.</p>
<p>There are many ways to <strong>store the attacked positions</strong>:</p>
<ul>
<li>By keeping <strong>all currently placed queens</strong> and checking whether the new position conflicts with some of them.</li>
<li>By keeping an int[,] <strong>matrix of all attacked positions</strong> and checking the new position directly in it. This will be complex to maintain because the matrix should change many positions after each queen placement/removal.</li>
<li>By keeping <strong>sets of all attacked rows, columns and diagonals</strong>. Let&rsquo;s try this idea:</li>
</ul>
<p>The above definitions have the following assumptions:</p>
<ul>
<li><strong>The Rows</strong> are 8, numbered from 0 to 7.</li>
<li><strong>The Columns</strong> are 8, numbered from 0 to 7.</li>
<li>The <strong>left diagonals</strong> are 15, numbered from -7 to 7. We can use the following formula to calculate the left diagonal number by row and column: leftDiag = col - row.</li>
<li>The <strong>right diagonals</strong> are 15, numbered from 0 to 14 by the formula: rightDiag = col + row.</li>
</ul>
<p>Let&rsquo;s take as an <strong>example</strong> the following chessboard with 8 queens placed on it at the following positions:</p>
<ul>
<li>{0, 0}; {1, 6}; {2, 4}; {3, 7}; {4, 1}; {5, 3}; {6, 5}; {7, 2}</li>
</ul>
<p>Following the definitions above for our example the <strong>queen {4, 1}</strong> occupies the <strong>row 4</strong>, <strong>column 1</strong>, <strong>left diagonal -3</strong> and <strong>right diagonal 5</strong>.</p>
<h2>4.&nbsp;&nbsp; Write the Backtracking Algorithm</h2>
<p>Now, it is time to write the recursive <strong>backtracking algorithm</strong> for placing the 8 queens.</p>
<p>The algorithm starts from row 0 and tries to place a queen at some column at row 0. On success, it tries to place the next queen at row 1, then the next queen at row 2, etc. until the last row is passed. The code for putting the next queen at a certain row might look like this:</p>
<p>Initially, we invoke this method from row 0:</p>
<h2>5.&nbsp;&nbsp; Check if a Position is Free</h2>
<p>Now, let&rsquo;s write <strong>the code to check whether a certain position is free</strong>. A position is free when it is not under attack by any other queen. This means that if some of the rows, columns or diagonals is already occupied by another queen, the position is occupied. Otherwise it is free. A sample code might look like this:</p>
<p>Recall that col-row is the number of the left diagonal and row+col is the number of the right diagonal.</p>
<h2>6.&nbsp;&nbsp; Mark / Unmark Attacked Positions</h2>
<p>After a queen is placed, we need to <strong>mark as occupied all rows, columns and diagonals</strong> that it can attack:</p>
<p>On removal of a queen, we will need a method to mark as free all rows, columns and diagonals that were attacked by it. Write it yourself:</p>
<h2>7.&nbsp;&nbsp; Print Solutions</h2>
<p>When a solution is found, it should be printed at the console. First, introduce a solutions counter to simplify checking whether the found solutions are correct:</p>
<p>Next, pass through all rows and through all columns at each row and <strong>print the chessboard cells</strong>:</p>
<h2>8.&nbsp;&nbsp; Testing the Code</h2>
<p>The "8 queens" puzzle has <strong>92 distinct solutions</strong>. Check whether your code generates and prints all of them correctly. The solutionsFound counter will help you check the number of solutions. Below are the 92 distinct solutions:</p>
<table>
<tbody>
<tr>
<td>&nbsp;</td>
<td colspan="7" width="1221">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
</tr>
<tr>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td width="171">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
</tbody>
</table>
<p>Submit your code in judge, printing all 92 solutions, separated by a single line.</p>
<h2>9.&nbsp;&nbsp; Optimize the Solution</h2>
<p>Now we can optimize our code:</p>
<ul>
<li>Remove the attackedRows It is not needed because all queens are placed consecutively at rows 0&hellip;7.</li>
<li>Try to use bool[] array for attackedColumns, attackedLeftDiagonals and attackedRightDiagonals instead of sets. Note that arrays are indexed from 0 to their size and cannot hold negative indexes.</li>
</ul>
<h2>* Permutation Based Solution</h2>
<p>Try to implement the more-efficient <strong>permutation-based solution</strong> of the "8 Queens" puzzle. Look at this code to grasp the idea: <a href="http://introcs.cs.princeton.edu/java/23recursion/Queens.java.html">http://introcs.cs.princeton.edu/java/23recursion/Queens.java.html</a>.</p>
<h1>Part III - Find All Paths in a Labyrinth</h1>
<p>You are given a labyrinth. Your goal is to find all paths from the start (cell 0, 0) to the exit, marked with 'e'.</p>
<ul>
<li>Empty cells are marked with a dash '-'.</li>
<li>Walls are marked with a star '*';</li>
</ul>
<p>On the first line, you will receive the dimensions of the labyrinth. Next you will receive the actual labyrinth.</p>
<p>The order of the paths does not matter.</p>
<h3>Examples</h3>
<table width="255">
<tbody>
<tr>
<td width="119">
<p><strong>Input</strong></p>
</td>
<td width="136">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>3</p>
<p>3</p>
<p>---</p>
<p>-*-</p>
<p>--e</p>
</td>
<td width="136">
<p>RRDD</p>
<p>DDRR</p>
</td>
</tr>
<tr>
<td width="119">
<p>3</p>
<p>5</p>
<p>-**-e</p>
<p>-----</p>
<p>*****</p>
</td>
<td width="136">
<p>DRRRRU</p>
<p>DRRRUR</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Create methods for reading and finding all paths in the labyrinth.</p>
<p>Create a static list that will hold every direction (basically the path)</p>
<p>Finding all paths should be recursive</p>
<p>Implement all helper methods that are present in the code above.</p>