<h1>Lab Exercises: Methodology of Problem Solving</h1>
<p>This document defines the <strong>in-class exercise</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<p>For the following exercises you are given a Visual Studio solution "<strong>Problem-Solving-Lab</strong>" holding portions of the source code. You can download it from the course&rsquo;s page. You can <strong>test your solutions in the Judge system </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/114#5"><strong>here</strong></a>.</p>
<h1>Part I &ndash; Blocks</h1>
<p>This first problem is <strong>combinatorial</strong>: generating all <strong>2 x 2 blocks</strong> holding <strong>n</strong> letters.</p>
<h2>Problem Description</h2>
<p>We are given an integer <strong>n</strong> (4 &le; <strong>n</strong> &le; 10). Using the <strong>first n capital Latin letters</strong>, generate all distinct <strong>blocks of </strong><strong>2 x 2 letters</strong>. Use each letter inside a block at most once (no repeating letters are allowed in the blocks). We assume that blocks obtained by <strong>rotating</strong> another block are the same and should be skipped.</p>
<p>Example: <strong>n = 4</strong>. The letters used in the blocks are:&nbsp; A, B, C, and D. The expected generated blocks are as follows:</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Note that the below blocks are the same (after <strong>rotation</strong>):</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>You can <strong>represent blocks as strings</strong>, e.g. the first block above is <strong>ABCD</strong> (take the corners from top to bottom and from left to right).</p>
<h2>Input</h2>
<p>The input holds a single integer number <strong>n</strong> (4 &le; <strong>n</strong> &le; 10).</p>
<h2>Output</h2>
<p>At the first line in the output, print the number of unique blocks in format:</p>
<table width="451">
<tbody>
<tr>
<td width="451">
<p>Number of blocks: {count}</p>
</td>
</tr>
</tbody>
</table>
<p>At the next lines <strong>print each unique block </strong>on a single line. The ordering of the lines is not strictly defined, but you should first generate all blocks starting with '<strong>A</strong>', then non-duplicate block starting with '<strong>B</strong>', etc.</p>
<h2>Sample Input and Output</h2>
<table width="545">
<tbody>
<tr>
<td width="148">
<p><strong>Input</strong></p>
</td>
<td width="397">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="148">
<p>4</p>
</td>
<td width="397">
<p>Number of blocks: 6</p>
<p>ABCD</p>
<p>ABDC</p>
<p>ACBD</p>
<p>ACDB</p>
<p>ADBC</p>
<p>ADCB</p>
</td>
</tr>
<tr>
<td width="148">
<p>5</p>
</td>
<td width="397">
<p>Number of blocks: 30</p>
<p>ABCD</p>
<p>ABCE</p>
<p>ABDC</p>
<p>ABDE</p>
<p>ABEC</p>
<p>ABED</p>
<p>ACBD</p>
<p>ACBE</p>
<p>ACDB</p>
<p>ACDE</p>
<p>ACEB</p>
<p>ACED</p>
<p>ADBC</p>
<p>ADBE</p>
<p>ADCB</p>
<p>ADCE</p>
<p>ADEB</p>
<p>ADEC</p>
<p>AEBC</p>
<p>AEBD</p>
<p>AECB</p>
<p>AECD</p>
<p>AEDB</p>
<p>AEDC</p>
<p>BCDE</p>
<p>BCED</p>
<p>BDCE</p>
<p>BDEC</p>
<p>BECD</p>
<p>BEDC</p>
</td>
</tr>
</tbody>
</table>
<h2>Provided Assets</h2>
<p>For this problem you are given a Visual Studio project called &ldquo;<strong>Blocks</strong>&rdquo; along with all tests from the Judge system in a solution folder called <strong>Blocks.Tests</strong>. You can use the <strong>in.txt</strong> files to test your program and compare the output with the contents of the respective <strong>out.txt</strong> file.</p>
<h2><strong>Analyze the Problem</strong></h2>
<p>What type of problem are we dealing with? We have some elements and we need to choose some of them and combine them to obtain some unique combination. This is obviously a <strong>combinatorics</strong> problem.</p>
<p>Since the order of elements matters and we always pick 4 elements out of a set with 4+ elements, what we need to generate are <strong>variations of 4 elements out of n elements</strong>. We don&rsquo;t take the same letter more than once, so we <strong>won&rsquo;t be interested in repetitions</strong>.</p>
<p>Knowing the type of problem and what needs to happen, the solution becomes much clearer. We can use the algorithm for generating variations we&rsquo;ve used before in the course. Experience with solving such problems is most helpful at this stage.</p>
<h2>Break Down the Problem</h2>
<p>Basically, the problem boils down to the following:</p>
<ul>
<li>We receive an integer from the console</li>
<li>Based on the received number we need to generate the letters we&rsquo;ll use for building the blocks</li>
<li>Generate all variations of 4 symbols using an algorithm you already know or one you can quickly find online</li>
<li>Save all blocks obtained in a collection</li>
<li>Keep track of rotated blocks &ndash; blocks obtained from other blocks by rotation</li>
<li>Output the results in the required format</li>
</ul>
<p>All steps are trivial except steps 3 and 5. At step 3 we can use an algorithm we&rsquo;ve used before and modify it. At step 5 we just need to save in a collection all blocks obtained after a rotation; once we have a block we need to rotate it three times and save each rotated block in the collection.</p>
<h2>Choose Appropriate Data Structures</h2>
<p>There are several structures we&rsquo;ll need based on what we&rsquo;ve outlined so far:</p>
<ul>
<li>A structure to hold the set of letters &ndash; an array of chars will do nicely</li>
<li>A structure to hold the currently obtained block &ndash; it should be of fixed size (4) and we should be able to modify/swap elements, so, again, an array of chars is appropriate</li>
<li>A structure to hold the results &ndash; since each block will be represented by a string and blocks should be unique, we can use a HashSet&lt;string&gt; for the results</li>
<li>A structure to hold the rotated blocks &ndash; again, blocks will be kept as strings, so a HashSet&lt;string&gt; will do</li>
</ul>
<h2>Solve the Problem Step by Step</h2>
<h3>Step 1. Get the Input Data</h3>
<p>This is easy, read a number from the console:</p>
<h3>Step 2. Generate the Set of Letters to Use</h3>
<p>We have the number n; we need to get n letters starting from 'A'. We can declare an array of chars to hold the letters and write a method to fill the letters in it:</p>
<p>The FillLetters() method is a simple loop which will traverse the array and place a letter in it. At each step we increment both the index we&rsquo;ll fill and the letter we&rsquo;ll use &ndash; the loop&rsquo;s iteration variable can be used to access the array&rsquo;s elements by index and obtain the letter:</p>
<p>Run the code to make sure we have the correct set of letters.</p>
<h3>Step 3. Generate Variations</h3>
<p>What we&rsquo;ll have in the end is a series of strings we&rsquo;ll keep in a collection. To make the code testable, it is a good idea to create a public method which accepts the size of the initial set as an argument and returns or fills the results in a HashSet.&nbsp; We can include the letter generation we just wrote in it:</p>
<p>If we decide to write unit tests for our application, this method is easy to use as it receives the number of letters and returns the resulting blocks.</p>
<p>When generating variations, we need to have: the set of letters, a place to hold the current combination, a way to check whether an element is already taken (since we need variations without repetition), the collection to hold the results, the collection to hold the rotated blocks and the index to start at. Quite a lot of things.</p>
<p>We can declare the collection containing the rotated blocks as static; alternatively, we can pass it as a parameter to all methods which need it. Here, we&rsquo;ll declare it as static above the Main() method.</p>
<p>We could do the same with the results, but in this case we&rsquo;ll create it inside the FindBlocks() method and return it.</p>
<p>Let&rsquo;s declare the variables we&rsquo;ll need and pass them to the method which generates the variations:</p>
<p>The current combination is always of length 4, so we&rsquo;ve used a constant.</p>
<p>The GenerateVariations() method is a modification of the algorithm to generate variations you probably know:</p>
<p>You can <strong>complete the TODOs in the else clause</strong>. As for adding the result to the resulting collection &ndash; that will require a separate method.</p>
<h3>Step 4. Add Unique Blocks to Result</h3>
<p>Let&rsquo;s create an AddResult() method and call it in the if clause above in place of the TODO.</p>
<p>The method should receive the current combination and the result collection; it can access the rotated blocks since they are kept in a static collection.</p>
<p>First, we&rsquo;ll obviously check if the combination is in the rotated blocks; if not &ndash; we add it to the result along with all rotated equivalents to the rotated blocks collection. This isn&rsquo;t too hard; having the array, just think about how the indices change when rotating the block:</p>
<h3>Step 5. Print Result</h3>
<p>Now that we have the results, we can print them. Let&rsquo;s use a method for this task as well; the Main() method will look like this:</p>
<p>The PrintBlocks() method is nothing special, it just prints the number of elements in the HashSet and then outputs each string on a separate line:</p>
<h2>Test the Solution</h2>
<p>Instead of unit tests, you can submit your code in the Judge system <a href="https://judge.softuni.bg/Contests/Practice/Index/114#5">here</a>. You can write your own tests if you&rsquo;d like, of course. If you did everything correctly, all tests should pass:</p>
<h2>Simplifying the Solution</h2>
<p>We used non-optimal <strong>problem solving strategy</strong> for the above problem. We implemented the <strong>first idea we had</strong> to solve this problem, without thinking about <strong>efficiency</strong>, <strong>simplicity</strong>, etc. Now, we can think about a better solution.</p>
<p>We have two points to optimize in our solution:</p>
<ul>
<li>We <strong>hold all generated blocks</strong> and <strong>rotate</strong> each new block to <strong>check for duplicates</strong>. This takes too much memory and slows down the solution. Can we check for duplicates in better way? Can we <strong>avoid generating duplicated blocks</strong>? Can we generate all blocks without duplicates directly?</li>
<li>Can we <strong>simplify the algorithm to generate the variations</strong> of 4 elements? We have a fixed number of elements &ndash; 4. Maybe we can use <strong>4 nested </strong>for<strong>-loops</strong>?</li>
</ul>
<h3>A Simpler Solution &ndash; 4 Nested Loops</h3>
<p>There is a much simpler way to arrive at the answers having in mind we always select 4 elements. Generating variations with recursion is easier to implement when we have an unknown number <strong>k</strong>, but when <strong>k</strong> is fixed, <strong>we can solve the problem using k nested loops</strong>. Each loop will take a letter; we then need to check for repetitions and if we have 4 different letters we print them. So, the problem can be solved like this:</p>
<p>To <strong>avoid checking for equal rotated blocks</strong> we use the following consideration: each block can be rotated in such a way, so <strong>its smallest letter is at the first position</strong> (at the top-left corner). For example, if we have a block <strong>DCBA</strong>, it can be rotated so that its smallest letter &lsquo;<strong>A</strong>&rsquo; comes at the first position. Thus, it is the same as <strong>ABCD</strong>. We may conclude, that all blocks can be obtained by putting the smallest letter at the first position and require that all other letters are bigger than the first. In the above code: the letter <strong>l1</strong> changes from [<strong>A</strong>&hellip;<strong>lastLetter</strong>] and <strong>l2</strong> &gt; <strong>l1</strong>, <strong>l3</strong> &gt; <strong>l1</strong> and <strong>l4</strong> &gt; <strong>l1</strong>.</p>
<p>You can test the above code to make sure it&rsquo;s correct.</p>
<h3>Calculating the Number of Blocks</h3>
<p>To calculate the <strong>number of blocks</strong>, you can use a <strong>counter in the innermost loop</strong>. On the output though, we need the number of blocks to come first which leaves us two choices, both of which don&rsquo;t seem very efficient:</p>
<ol>
<li>Store the results in a collection and then print it (takes up more memory and iterates the blocks twice)</li>
<li>First iterate to count the blocks (4 nested loops) and then iterate to print them (4 nested loops again, double the work).</li>
</ol>
<p>The next thing to ask ourselves is: isn&rsquo;t there a <strong>formula to calculate the number of blocks</strong> we&rsquo;ll obtain?</p>
<p>We can check. Once we have a working solution we can print the number of blocks for several consecutive inputs and write down the results. There is an <a href="https://oeis.org/">online encyclopedia of integer sequences</a>; you can input a sequence of numbers and you can <strong>find a formula</strong> for calculating what the result would be based on the input number. You&rsquo;ll probably get more than one match; the more numbers you enter, the better the chance you&rsquo;ll find what you&rsquo;re looking for. For instance, enter the first 5 results (for n = 4, 5, 6, 7 and 8): <strong>6, 30, 90, 210, 420</strong>. The online encyclopedia prints a formula matching these numbers:&nbsp; a(n) = n * (n + 1) * (n + 2) * (n + 3) / 4.</p>
<p>Have in mind that for this function a(1) = 6, which is what we want for input 4. Basically, when we get, say 8 as input, we actually need a(5) which is a(8 &ndash; 3). So, the actual <strong>formula</strong> we need would turn into:</p>
<p>(n &ndash; 3) * (n &ndash; 2) * (n &ndash; 1) * n / 4</p>
<p>You can print the result of this expression above the nested loops and check it in the Judge system, it turns out it is correct! So, now we calculate the number of blocks with a simple formula and we only iterate once to print them which is a great improvement over the first idea we explored &ndash; using the recursive algorithm for generating variations.</p>
<h1>Part II &ndash; Zig-Zag Matrix</h1>
<p>You are given a <strong>matrix of positive integer numbers</strong>. A <strong>sig-zag path</strong> in the matrix starts from some cell in the first column, goes to some cell <strong>up</strong> in the second column, then to some cell <strong>down</strong> in the third column, etc. until the last column is reached. Your task is to write a program that finds the zigzag path with the <strong>maximal sum</strong>. Example:</p>
<p>If multiple maximal zigzag paths exist, print the first one which uses the upper-most cell possible at each column (from left to right).</p>
<p>On the first line of input you&rsquo;ll receive the number of rows N. On the second line you&rsquo;ll receive the number of columns M. &nbsp;On each of the next N rows you&rsquo;ll receive M positive integer numbers separated by a comma (',').</p>
<p>Print the maximal sum along with the path followed in format: {maxSum} = {cell1} + {cell2} + &hellip; + {cellM}. You can test your solution to the problem <a href="https://judge.softuni.bg/Contests/Practice/Index/114#6">here</a>.</p>
<table width="1397">
<tbody>
<tr>
<td width="668">
<p><strong>Input</strong></p>
</td>
<td width="730">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="668">
<p>4</p>
<p>4</p>
<p>2,4,5,6</p>
<p>9,7,1,5</p>
<p>8,7,7,9</p>
<p>8,2,6,4</p>
</td>
<td width="730">
<p>30 = 8 + 7 + 6 + 9</p>
</td>
</tr>
<tr>
<td width="668">
<p>17</p>
<p>4</p>
<p>714,52,415,740</p>
<p>102,321,549,697</p>
<p>44,830,171,952</p>
<p>414,58,309,16</p>
<p>956,596,667,526</p>
<p>711,691,776,214</p>
<p>617,919,924,536</p>
<p>102,637,758,360</p>
<p>446,315,243,132</p>
<p>856,313,794,920</p>
<p>732,566,376,314</p>
<p>891,869,999,456</p>
<p>363,869,471,137</p>
<p>650,108,393,24</p>
<p>277,201,124,184</p>
<p>397,13,596,408</p>
<p>73,811,506,100</p>
</td>
<td width="730">
<p>3761 = 891 + 919 + 999 + 952</p>
</td>
</tr>
<tr>
<td width="668">
<p>5</p>
<p>10</p>
<p>339,575,789,846,979,801,574,337,95,863</p>
<p>612,383,154,963,796,733,748,281,370,854</p>
<p>675,164,992,998,38,958,856,214,567,348</p>
<p>857,709,774,768,270,798,663,440,506,66</p>
<p>458,172,785,558,953,312,854,131,222,250</p>
</td>
<td width="730">
<p>7919 = 857 + 575 + 992 + 963 + 953 + 958 + 854 + 337 + 567 + 863</p>
</td>
</tr>
</tbody>
</table>
<h2>Provided Assets</h2>
<p>For this problem you&rsquo;re given a project <strong>Zigzag-Matrix</strong> and a solution folder called <strong>Zigzag-Matrix.Tests </strong>which holds all tests from the Judge system.</p>
<h2>Analyze the Problem</h2>
<p>We&rsquo;re looking for a path in a matrix. At first, it might occur to you that this can be solved by an algorithm like Dijkstra&rsquo;s. We need, however, just one cell from each column and based on the cells we choose we&rsquo;ll have a different number of available next cells moving forward.</p>
<p>We can try a greedy approach by taking the biggest cell from each column. But the problem restricts the available cells we can take because once we decide to take a cell on a given column, on the next column we should check either above or below it. What if in the first column we have the largest value at cell (0, 0)? We are only allowed to move up afterwards, but we&rsquo;re at the first row, so we&rsquo;ll have nowhere to go. A greedy algorithm will not work.</p>
<p>The best option we have based on what we&rsquo;ve learned so far is to use <strong>dynamic programming</strong> &ndash; for each cell find the maximum path and then recover the path when we find the global maximum.</p>
<h2>Break Down the Problem</h2>
<p>An outline of a dynamic programming solution is pretty straightforward:</p>
<ul>
<li>Read the input and fill the matrix we&rsquo;ll be working with</li>
<li>Using DP find the maximal path leading to each cell</li>
<li>Recover the path after the DP algorithm is finished</li>
<li>Print the output</li>
</ul>
<h2>Choose Appropriate Data Structures</h2>
<p>At first glance, we&rsquo;ll obviously need the following structures:</p>
<ul>
<li>A matrix of integers which we receive as input</li>
<li>A matrix to hold the max path for each cell (we&rsquo;ll fill this using a DP approach)</li>
<li>An array to keep track of the path we need to take once we&rsquo;re done (this is trickier though, an array won&rsquo;t do, we&rsquo;ll see why later)</li>
<li>At some point, we&rsquo;ll need a list for the path when we recover it, but we&rsquo;ll create it when we reach that point</li>
</ul>
<h2>Solve the Problem Step by Step</h2>
<h3>Step 1. Read the Input</h3>
<p>It&rsquo;s up to you whether you prefer using a two-dimensional matrix or a jagged array. Here, we&rsquo;ll use a jagged array to simplify the parsing of the input.</p>
<p>Read the dimensions, create the matrix and then fill it:</p>
<p>We&rsquo;ll separate the parsing of the matrix in a method. Since we have a jagged array (array of arrays), we can simply split each row and convert it to an array of integers using LINQ:</p>
<h3>Step 2. Dynamic Programming &ndash; Setup</h3>
<p>It&rsquo;s not that hard to see that keeping the max path for each cell will require another matrix with the same dimensions as the one we get at the input.</p>
<p>It&rsquo;s much harder to see what we&rsquo;ll need to recover the path though. We take one cell from each column, so why not keep the row index for each column in an array?</p>
<p>If you think about it, you&rsquo;ll see this won&rsquo;t work. Dynamic programming works by checking each path to find the optimum. At any given column though, there may be better paths (up to that point) than the global maximum. If we keep row indices in an array, we run the risk of overwriting the values in it based on local maximums. Once we find a better path later on, we&rsquo;ll have no way of recovering the path that led to it, as the array holds a different path, one that was better up to a point, but turned out to be non-optimal.</p>
<p>So, the way to approach this is to <strong>hold the path in yet another matrix</strong> &ndash; for each cell we&rsquo;ll keep the row index of the cell which led to it in order to produce the maximal path for that cell.</p>
<p>Having all this in mind, we&rsquo;ll have the following setup:</p>
<p>Another thing we need to do before we start with the DP algorithm, is to ensure we have a starting point.&nbsp; We&rsquo;ll be traversing the columns first, then the cells at each row, therefore, we need to initialize the first column. As pointed out before, cell (0, 0) is impossible to reach, but all others are and the maximal value for each is just the value of the cell:</p>
<h3>Step 3. Dynamic Programming &ndash; Implementation</h3>
<p>Once we have the first column initialized, we can start filling all the others &ndash; first the columns and then the rows.</p>
<p>Note that this will take care of the requirement &ndash; " If multiple maximal zigzag paths exist, print the first one which uses the upper-most cell possible at each column (from right to left)."</p>
<p>We&rsquo;ll only fill the value in each cell with the best path which uses the upper-most cell from the previous column; this is guaranteed because of the way we traverse the rows &ndash; from row 0 to the last.</p>
<p>Next, for each cell we need to find the best path. We do this by <strong>adding the cell&rsquo;s value to the best path from the previous column</strong>. Because of the zigzag requirement, <strong>we need to check if the column is even or odd</strong>. If the column is odd, this means the path needs to come from a cell below the current one; if the column is even we&rsquo;ll check only rows which are above the current cell&rsquo;s row. The algorithm is the same, we just loop different parts of the column.</p>
<p>We can declare the maximal path of the previous column in a separate variable:</p>
<p>Note: again, we traverse the rows in increasing order to ensure the final result will contain the max path with upper-most cells.</p>
<p>Once we have the previous maximum, the maximum for the current cell is just the sum of the previous max and its value:</p>
<h3>Step 4. Recover the Path</h3>
<p>So far we didn&rsquo;t keep the global maximum anywhere, so we&rsquo;ll need to manually check what is the row index of the last cell in the path:</p>
<p>We just traverse the last column and get the row index of the max value contained in the maxPaths matrix:</p>
<p>Once we have the row, we can recover the path:</p>
<p>The RecoverMaxPath() method will start at the currentRowIndex and the last column and follow the path kept in previousRowIndex for that cell. It will put each cell value in a list and reverse it before returning it:</p>
<p>Complete the TODOs to recover the maximal path.</p>
<h2>Test the Solution</h2>
<p>Test your solution in the Judge system <a href="https://judge.softuni.bg/Contests/Practice/Index/114#6">here</a>. If your implementation is correct all tests should pass:</p>