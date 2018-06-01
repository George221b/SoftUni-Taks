<h1>Lab: AJAX &amp; jQuery AJAX</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-applications">&ldquo;JavaScript Applications&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/Compete/Index/357">https://judge.softuni.bg/Contests/Compete/Index/357</a>.</p>
<h2>1.&nbsp;&nbsp; XHR (XmlHttpRequest)</h2>
<p>Your task is to <strong>write</strong> a JS function that <strong>loads</strong> a github repository <strong>asynchronously with AJAX</strong>. You should <strong>create</strong> an instance of <strong>XmlHttpRequest</strong> an attach an <strong>onreadystatechange</strong> event to it. (An EventHandler that is called whenever the readyState attribute changes). In your event handler when the <strong>readyState</strong> attribute reaches a value of <strong>4</strong> (it is ready), replcae the text content of a<strong> div</strong> element with <strong>id "res"</strong> with the value of the <strong>responseText</strong> property of the request. <strong>Do not format</strong> the response in any way. Submit your loadRepos function.</p>
<p><a href="https://developer.mozilla.org/en-US/docs/Web/API/XMLHttpRequest/open">&nbsp;More on XmlHttpRequest.open()</a></p>
<h3>Skeleton</h3>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>xmlhttprequest-example.html</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;meta charset="UTF-8"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;title&gt;XmlHttpRequest Example&lt;/title&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;script src="scripts/1.xhr.js"&gt;&lt;/script&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body&gt;</p>
<p>&lt;button onclick="loadRepos()"&gt;Load Repos&lt;/button&gt;</p>
<p>&lt;div id="res"&gt;&lt;/div&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp;&nbsp; function loadRepos() {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// TODO</em></p>
<p>&nbsp;&nbsp; }</p>
<p>&lt;/script&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<h2>2.&nbsp;&nbsp; AJAX Load</h2>
<p>Use <strong>jQuery</strong> to <strong>write</strong> a JS function that loads an online resource into a div with <strong>id "text".</strong> Make a request to "<strong>text.html</strong>" and replace the target div&rsquo;s content with the returned <strong>HTML</strong>. Create the files ajax-load.html and text.html and place them in the same folder, so that your script can find the latter.</p>
<p>Submit your loadTitle function.</p>
<h3>Skeleton</h3>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>ajax-load.html</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;meta charset="UTF-8"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;title&gt;AJAX Load Example&lt;/title&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;script src="https://code.jquery.com/jquery-3.1.1.min.js"&gt;&lt;/script&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body&gt;</p>
<p>&lt;div id="text"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;h1&gt;AJAX jQuery.load()&lt;/h1&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;button onclick="loadTitle()"&gt;Load Title&lt;/button&gt;</p>
<p>&lt;/div&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>text.html</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;h1&gt;Voilla!&lt;/h1&gt;</p>
<p>&lt;p&gt;I am a text loaded with AJAX request&lt;/p&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>ajax-load.js</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>function loadTitle() {</p>
<p>&nbsp; <em>// TODO</em></p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Github Repos</h2>
<p>Your task is to <strong>write</strong> a JS function that <strong>executes</strong> an <strong>AJAX</strong> request with <strong>jQuery</strong> and loads all user <strong>github repositories</strong> by a given username (taken from input field with <strong>id "</strong><strong>username</strong><strong>"</strong>) into a <strong>list</strong> (each repository as a <strong>list-item</strong>) with <strong>id</strong> "<strong>repos</strong>". Use the properties full_name and html_url of the returned objects to create a link to each repo&rsquo;s GitHub page. If an <strong>error</strong> occurs (like 404 &ldquo;Not Found&rdquo;), <strong>append</strong> to the list a list-item with <strong>text</strong> "Error" instead. Clear the contents of the list before any new content is appended. See the <strong>highlighted lines</strong> of the skeleton for formatting details of each list item. Submit your loadRepos function.</p>
<h3>Skeleton</h3>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>github-repos.html</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;meta charset="UTF-8"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;title&gt;GitHub Repos&lt;/title&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;script src="https://code.jquery.com/jquery-3.1.1.min.js"&gt;&lt;/script&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body&gt;</p>
<p>GitHub username:</p>
<p>&lt;input type="text" id="username" value="k1r1L" /&gt;</p>
<p>&lt;button onclick="loadRepos()"&gt;Load Repos&lt;/button&gt;</p>
<p>&lt;ul id="repos"&gt;</p>
<p>&nbsp; &lt;li&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;a href="<em>{repo.html_url}</em>"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>{repo.full_name}</em></p>
<p>&nbsp;&nbsp;&nbsp; &lt;/a&gt;</p>
<p>&nbsp; &lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp;&nbsp;&nbsp; function loadRepos() {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// AJAX call &hellip; </em></p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&lt;/script&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<h2>4.&nbsp;&nbsp; Phonebook</h2>
<p>Use <strong>Firebase</strong> and <strong>jQuery</strong> to create a simple phonebook app. The user should be able to see all contacts, <strong>loaded</strong> from the server, <strong>create</strong> a new contact and <strong>delete</strong> any of the contacts. Use the lecture presentation for detailed instructions on this task. Place your code in a file called "phonebook.js", as shown in the skeleton. This task is not evaluated by the Judge, it is for practice only.</p>
<h3>Skeleton</h3>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>github-repos.html</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp; &lt;meta charset="UTF-8"&gt;</p>
<p>&nbsp; &lt;title&gt;Phonebook&lt;/title&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body&gt;</p>
<p>&nbsp; &lt;h1&gt;Phonebook&lt;/h1&gt;</p>
<p>&nbsp; &lt;ul id="phonebook"&gt;&lt;/ul&gt;</p>
<p>&nbsp; &lt;button id="btnLoad"&gt;Load&lt;/button&gt;</p>
<p>&nbsp; &lt;h2&gt;Create Contact&lt;/h2&gt;</p>
<p>&nbsp; Person: &lt;input type="text" id="person" /&gt;</p>
<p>&nbsp; &lt;br&gt;</p>
<p>&nbsp; Phone: &lt;input type="text" id="phone" /&gt;</p>
<p>&nbsp; &lt;br&gt;</p>
<p>&nbsp; &lt;button id="btnCreate"&gt;Create&lt;/button&gt;</p>
<p>&nbsp; &lt;script src="phonebook.js"&gt;&lt;/script&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&nbsp;</p>