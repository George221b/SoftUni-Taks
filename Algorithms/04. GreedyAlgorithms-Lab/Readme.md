<h1>Exercises: Greedy Algorithms</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<p>For the following exercises you are given a Visual Studio solution "<strong>Greedy-Algorithms-Lab</strong>" holding portions of the source code + unit tests. You can download it from the course&rsquo;s page.</p>
<h1>Part I &ndash; Sum of Coins</h1>
<p>Let&rsquo;s have a <strong>range of possible coin values</strong> (e.g. 1, 2, 5, 10, 20, 50) and a <strong>desired sum</strong>. In this problem, the goal is to <strong>reach the sum using as few coins as possible using a greedy approach</strong>. We&rsquo;ll assume that each coin value and the desired sum are <strong>integers</strong>, but we can easily modify the problem to accommodate floating-point values using the decimal type in C#.</p>
<p>Examples:</p>
<table width="1389">
<tbody>
<tr>
<td width="458">
<p><strong>Input</strong></p>
</td>
<td width="587">
<p><strong>Output</strong></p>
</td>
<td width="344">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="458">
<p>Coins: 1, 2, 5, 10, 20, 50</p>
<p>Sum: 923</p>
</td>
<td width="587">
<p>Number of coins to take: 21</p>
<p>18 coin(s) with value 50</p>
<p>1 coin(s) with value 20</p>
<p>1 coin(s) with value 2</p>
<p>1 coin(s) with value 1</p>
</td>
<td width="344">
<p>18*50 + 1*20 + 1*2 + 1*1 = 900 + 20 + 2 + 1 = 923</p>
</td>
</tr>
<tr>
<td width="458">
<p>Coins: 1</p>
<p>Sum: 42</p>
</td>
<td width="587">
<p>Number of coins to take: 42</p>
<p>42 coin(s) with value 1</p>
</td>
<td width="344">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="458">
<p>Coins: 3, 7</p>
<p>Sum: 11</p>
</td>
<td width="587">
<p>Error</p>
</td>
<td width="344">
<p>Cannot reach desired sum with these coin values</p>
</td>
</tr>
<tr>
<td width="458">
<p>Coins: 1, 2, 5</p>
<p>Sum: 2031154123</p>
</td>
<td width="587">
<p>Number of coins to take: 406230826</p>
<p>406230824 coin(s) with value 5</p>
<p>1 coin(s) with value 2</p>
<p>1 coin(s) with value 1</p>
</td>
<td width="344">
<p>Solution should be fast enough to handle a combination of small coin values and a large desired sum</p>
</td>
</tr>
<tr>
<td width="458">
<p>Coins: 1, 9, 10</p>
<p>Sum: 27</p>
</td>
<td width="587">
<p>Number of coins to take: 9</p>
<p>2 coin(s) with value 10</p>
<p>7 coin(s) with value 1</p>
</td>
<td width="344">
<p>Greedy approach produces non-optimal solution (9 coins to take instead of 3 with value 9)</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Provided Assets</h2>
<p>For this problem you are given one project to hold the solution and a unit test project:</p>
<p>In the <strong>SumOfCoins</strong> project you are given an implemented Main() method with sample data. Your task is to implement the ChooseCoins() method:</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests to Make Sure They Fail</h2>
<p>The algorithm is not implemented yet, so all unit tests should fail:</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Greedy Approach to Solution</h2>
<p>For this problem, a greedy algorithm will attempt to take the best possible coin value (which is the largest), then take the next largest coin value and so on, until the sum is reached or there are no coin values left.</p>
<p>There may be a different amount of coins to take for each value. In one of the examples above we had a very large desired sum and relatively small coin values, which means we&rsquo;ll need to take a lot of coins. It would not be efficient (and may even cause an Exception) if we return the result as a List&lt;int&gt;; a more practical way to do it is to use a <strong>Dictionary&lt;int, int&gt;</strong> where the keys are the coin values and the values are the number of coins to take for the specified coin value. Therefore, in the second example (coin values = { 1 }, sum = 42), instead of returning a list with 42 elements in it, we&rsquo;ll return a dictionary with a single key-value pair: 1 =&gt; 42.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sort Coin Values</h2>
<p>Since at each step we&rsquo;ll try to take the largest value we haven&rsquo;t yet tried, it would simplify our work to order the coin values in descending order. We can use LINQ:</p>
<p>Now taking the largest coin value at each step is simply a matter of iterating the list.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Greedy Algorithm Implementation</h2>
<p>We&rsquo;ll need several variables to keep track of:</p>
<ul>
<li>We&rsquo;ll need, of course, the resulting dictionary.</li>
<li>We&rsquo;ll be iterating a list, so we also need to know where we&rsquo;re at &ndash; an index variable.</li>
<li>Finally, since it&rsquo;s possible to finish the algorithm without reaching the desired sum, we&rsquo;ll keep track of the current amount taken in a separate variable (when we&rsquo;re done, we&rsquo;ll check it against the desired sum to see if we got a solution or not).</li>
</ul>
<p>Having these variables, when do we stop taking coins? There are two possibilities: 1) we reached the desired sum; 2) we ran out of coin values. We can put these two conditions in a while loop like this:</p>
<p>In the while loop, we need to decide how many coins to take of the current value. We take the current value from the list, we have its index:</p>
<p>So far, we&rsquo;ve accumulated some amount in the currentSum variable, the difference between targetSum and currentSum will give us the remaining sum we need to obtain:</p>
<p>So, how many coins do we take? Using integer division, we can just divide remainingSum over the current coin value to find out:</p>
<p>All we have to do now is put this information in the resulting dictionary as a key-value pair (only if we can take coins with this value), then increment the current index to move on to the next coin value:</p>
<p>Finally, return the resulting dictionary.</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests</h2>
<p>We missed something, so one of the unit tests should not pass:</p>
<p>As you can see, this solution doesn&rsquo;t work when we have an unreachable sum. We need to throw an error if the algorithm fails to produce a result.</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Check if Sum is Reached</h2>
<p>Having the targetSum and currentSum, we just need to compare them. If they&rsquo;re not equal, we haven&rsquo;t reached a solution, so an error should be thrown before returning the resulting dictionary:</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests One Last Time</h2>
<p>When we&rsquo;ve taken care of situations where the greedy approach fails to produce a result, the unit tests should all pass:</p>
<h1>Part II &ndash; Set Cover Problem</h1>
<p>In the Set Cover Problem, we are given two sets - a set of sets (we&rsquo;ll call it sets) and a universe. The sets contain all elements from universe and no others, however, some elements are repeated. The task is to <strong>find the smallest subset of </strong>sets<strong> which contains all elements in </strong>universe<strong>. </strong></p>
<p>Examples:</p>
<table width="1255">
<tbody>
<tr>
<td width="668">
<p><strong>Input</strong></p>
</td>
<td width="587">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="668">
<p>Universe: 1, 2, 3, 4, 5</p>
<p>Number of sets: 4</p>
<p>1</p>
<p>2, 4</p>
<p>5</p>
<p>3</p>
</td>
<td width="587">
<p>Sets to take (4):</p>
<p>{ 2, 4 }</p>
<p>{ 1 }</p>
<p>{ 5 }</p>
<p>{ 3 }</p>
</td>
</tr>
<tr>
<td width="668">
<p>Universe: 1, 2, 3, 4, 5</p>
<p>Number of sets: 4</p>
<p>1, 2, 3, 4, 5</p>
<p>2, 3, 4, 5</p>
<p>5</p>
<p>3</p>
</td>
<td width="587">
<p>Sets to take (1):</p>
<p>{ 1, 2, 3, 4, 5 }</p>
</td>
</tr>
<tr>
<td width="668">
<p>Universe: 1, 3, 5, 7, 9, 11, 20, 30, 40</p>
<p>Number of sets: 6</p>
<p>20</p>
<p>1, 5, 20, 30</p>
<p>3, 7, 20, 30, 40</p>
<p>9, 30</p>
<p>11, 20, 30, 40</p>
<p>3, 7, 40</p>
</td>
<td width="587">
<p>Sets to take (4):</p>
<p>{ 3, 7, 20, 30, 40 }</p>
<p>{ 1, 5, 20, 30 }</p>
<p>{ 9, 30 }</p>
<p>{ 11, 20, 30, 40 }</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Provided Assets</h2>
<p>For the set problem, you are given two projects &ndash; one to hold the solution and a unit test project:</p>
<p>You are given sample input in the Main() method, your task is to complete the ChooseSets() method:</p>
<h2>Problem 10. &nbsp;Run the Unit Tests to Make Sure They Fail</h2>
<p>The unit tests should all fail initially:</p>
<h2>Problem 11. Greedy Approach to Solution</h2>
<p>Using the greedy approach, at each step we&rsquo;ll take the set which contains the most elements present in the universe which we haven&rsquo;t yet taken. At the first step, we&rsquo;ll always take the set with the largest number of elements, but it gets a bit more complicated afterwards.</p>
<p>To simplify our job (and not check against two sets at the same time), when taking a set, we can remove all elements in it from the universe. We can also remove the set from the sets we&rsquo;re considering. This is the reason for calling ToList() on both the sets and universe when calling the ChooseSets() method inside the Main() method.</p>
<h2>Problem 12. &nbsp;Greedy Algorithm Implementation</h2>
<p>The method will return a list of arrays, so first thing&rsquo;s first, initialize the resulting list:</p>
<p>As discussed in the previous section, we&rsquo;ll be removing elements from the universe, so we&rsquo;ll be repeating the next steps until the universe is empty:</p>
<p>The hardest part is selecting a set. We need to get the set which has the most elements contained in the universe. We can use LINQ to sort the sets and then take the first set (the one with most elements in the universe):</p>
<p>Sorting the sets at each step is probably not the most efficient approach, but it&rsquo;s simple enough to understand. The above LINQ query tests each element in a set to see if it is contained in the universe and sorts the sets (in descending order, from largest to smallest) based on the number of elements in each set which are in the universe.</p>
<p>Once we have the set we&rsquo;re looking for, the next steps are trivial. Complete the TODOs below:</p>
<p>This is all, we just need to run the unit tests to make sure we didn&rsquo;t make a mistake along the way.</p>
<h2>Problem 13. &nbsp;Run the Unit Tests</h2>
<p>If you did everything correctly, the unit tests should pass:</p>
<p>Congratulations, you&rsquo;re done!</p>