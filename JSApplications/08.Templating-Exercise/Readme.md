<h1>Exercises: Templating</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-applications">&ldquo;JavaScript Applications&rdquo; course @ SoftUni</a>.</p>
<p><strong>The following tasks have no automated test &ndash; submit your solutions for peer review on the course page.</strong></p>
<h2>1.&nbsp;&nbsp; List Towns</h2>
<p>You are a given an <strong>input field</strong> with a <strong>button</strong>. In the input field you should enter <strong>elements</strong> <strong>separated</strong> by comma and whitespace ("<strong>, </strong>"). Your task is to create a simple <strong>template</strong> that defines a <strong>list</strong> of towns. Each <strong>town</strong> comes from the <strong>input</strong> field.</p>
<table width="1361">
<tbody>
<tr>
<td width="1361">
<p>listtown.html</p>
</td>
</tr>
<tr>
<td width="1361">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;List Town&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"node_modules/handlebars/dist/handlebars.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"towns.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>input </strong><strong>id=</strong><strong>"towns" </strong><strong>type=</strong><strong>"text"</strong>/&gt;<br /> &lt;<strong>button </strong><strong>id=</strong><strong>"btnLoadTowns"</strong>&gt;Load&lt;/<strong>button</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"root"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; $(() =&gt; <em>attachEvents</em>())<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script </strong><strong>type=</strong><strong>"text/x-handlebars-template" </strong><strong>id=</strong><strong>"towns-template"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; // TODO: Create the template here<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>In your <strong>attachEvents</strong>() function you <strong>should</strong> attach a click event to the <strong>button</strong> with <strong>id &ldquo;btnLoadTowns&rdquo;</strong> and <strong>render</strong> the <strong>towns</strong> that come from the input field in the html <strong>template</strong> with <strong>id &ldquo;towns-template&rdquo;</strong></p>
<h3><br /> Screenshots</h3>
<p>This is how the html look like:</p>
<h2>2.&nbsp;&nbsp; HTTP Status Cats</h2>
<p><a href="https://softuni.bg/downloads/svn/js-core/May-2017/JS-Apps-Jun-2017/10.%20JS-Apps-Templating-Exercises/Handlebars-Exercises-Skeleton.zip">Download project skeleton</a>.</p>
<p>We all love cats. They are also a fun way to learn all the HTTP status codes.</p>
<p>Your task is to <strong>refactor</strong> the given <strong>html</strong> and to create a <strong>template</strong> to represent <strong>each</strong> cat card block on it&rsquo;s own. After you have <strong>created</strong> the templete <strong>render</strong> it into the div with <strong>id &ldquo;allCats&rdquo;.</strong></p>
<p>A <strong>cat</strong> has an <strong>id, statusCode, statusMessage </strong>and<strong> imageLocation</strong>. The cats are <strong>seeded</strong> using the <strong>function</strong> from the js <strong>file</strong> named <strong>catSeeder</strong>.js</p>
<p>Each card block has a <strong>button</strong> that <strong>unveils</strong> status code information <strong>connected</strong> to each cat. You should <strong>toggle</strong> the button and change it&rsquo;s text from &ldquo;<strong>Show status code</strong>&rdquo; to &ldquo;<strong>Hide status code</strong>&rdquo;.</p>
<h3>Screenshots</h3>
<h2>3.&nbsp;&nbsp; Refactor &ldquo;Prodavachnik&rdquo;</h2>
<p>Take the Prodavachnik application from the previous exercise (<a href="https://softuni.bg/trainings/resources/officedocument/17294/exercise-problem-descriptions-js-applications-july-2017">Exercise: Single Page Applications</a>) and <strong>refactor</strong> it to use <strong>Handlebars templates</strong>. Take the markup for each relevant section and place it in its own template. When the user navigates around the site, instead of hiding and showing content, only the needed template will be rendered.</p>
<p>Try to <strong>reuse</strong> as much of the markup as possible &ndash; for example, the login and register pages can use the same template, as well as create and edit ad. Use a <strong>partial template</strong> for each individual ad.</p>
<p>For the ads catalog, use whichever style you prefer &ndash; as rows in a table or as individual divs.</p>
<h3>Hints</h3>
<p>The ads array that you fetch from the server can be render using an each helper. For the header, use a <strong>conditional statement</strong> that only shows the links and user greeting that apply to the current session state (logged in or not). Whenever the session state changes (on page load, when the user logs in, registers, or logs out), re-render the header.</p>