<h1>Exercises: Single Page Apps with AJAX, REST and Kinvey</h1>
<p>Problems for exercise at the <a href="https://softuni.bg/courses/javascript-applications">&ldquo;JavaScript Applications&rdquo; course @ SoftUni</a>. Submit your solution in the SoftUni <a href="https://softuni.bg/trainings/1505/js-applications-november-2016">instance</a> as homework. You can use this <a href="https://softuni.bg/downloads/svn/js-core/Sept-2016/JS-Apps-Nov-2016/7.%20JS-Apps-SPA-with-AJAX-REST-Kinvey/7.%20JS-Apps-SPA-with-AJAX-REST-Kinvey.pptx">presentation</a> to help you throughout this exercise.</p>
<h2>1.&nbsp;&nbsp; Prodavachnik</h2>
<p>Your task is to implement a Web page that serves the functionally of an <strong>advertisement</strong> <strong>site</strong>, which specializes in <strong>selling</strong> <strong>products</strong>/<strong>services</strong>. The API will consist of creating, listing, editing and deleting of <strong>advertisements</strong>(<strong>CRUD</strong>). Every <strong>advert</strong> should contain the following properties:</p>
<ul>
<li>Title - String</li>
<li>Description - String</li>
<li>Publisher - String</li>
<li>Date of Publishing &ndash; Date (format &ldquo;<strong>mm/dd/yyyy</strong>&rdquo;)</li>
<li>Price &ndash; <strong>floating</strong> point number, to the <strong>second</strong> <strong>digit</strong> after decimal separator.</li>
</ul>
<p>You can download the skeleton (HTML and CSS) <a href="https://softuni.bg/downloads/svn/js-core/May-2017/JS-Apps-Jun-2017/8.%20JS-Apps-Single-Page-Applications-Exercises/Prodavachnik%20-%20Skeleton.zip">here</a>.</p>
<h3><br /> Screenshots</h3>
<p>Home page:</p>
<p>&nbsp;</p>
<p><br /> Registration page (Login page is identical):</p>
<p><br /> This is how the website should look like when there are no adverts:</p>
<p>&nbsp;</p>
<p>Let&rsquo;s create one (the view for editing an advert is identical):</p>
<p>And this is how it should be listed:</p>
<p>&nbsp;</p>
<p>The advertisement site should have the following functionality:</p>
<ul>
<li>Perform any <strong>CRUD</strong> operations over the advertisement entity.
<ul>
<li>Note that the <strong>publisher</strong> of the advertisement is the <strong>currently</strong> logged <strong>user</strong>.</li>
<li>Publisher can edit/delete his own adverts only.</li>
</ul>
</li>
<li>Have <strong>Register</strong>/<strong>Login</strong>/<strong>Logout</strong>.</li>
</ul>
<h3>Hints</h3>
<ul>
<li><br /> When <strong>create</strong> an <strong>advertisement</strong> the current logged user should be it&rsquo;s <strong>publisher</strong>. We can do it by making one request to the database (by user&rsquo;s <strong>&ldquo;_id&rdquo;</strong> property) and retrieve the whole <strong>user</strong> It may look something like that:</li>
</ul>
<p><br /> Once we got the user information we can use it in our &ldquo;afterPublisherRequest&rdquo; method:</p>
<p>And the rest is <strong>parsing</strong> the <strong>information</strong> from the form and sending <strong>another</strong> <strong>request</strong> &ndash; this time to <strong>save</strong> our <strong>advert</strong> in database.</p>
<p><strong>Note</strong> that the above method should be called when the form for <strong>advert</strong> <strong>creation</strong> is <strong>submitted</strong>.</p>
<ul>
<li>When <strong>editing</strong> an advert in which we don&rsquo;t want to change the <strong>publisher</strong> you can include it in the html, but mark it as &ldquo;hidden&rdquo;, here is how the html might look:</li>
</ul>
<p>What is left is to <strong>initially</strong> <strong>set </strong>the <strong>value</strong> when printing the edit form <strong>and</strong> then <strong>parsing</strong> the whole <strong>data</strong> when the form is <strong>submitted</strong>.</p>
<h2>2.&nbsp;&nbsp; Extend &ldquo;Prodavachnik&rdquo; (Optional)</h2>
<p>Your task is to extend the functionality of the above project (when completed).</p>
<p>What have to be done is:</p>
<ol>
<li>Creating <strong>one</strong> <strong>more</strong> <strong>view</strong>(&ldquo;section&rdquo;), which will be used to <strong>display</strong> one <strong>single</strong> <strong>advertisement</strong>. The view should be accessible when you list all advertisements (by creating another <strong>link</strong> &ndash; &ldquo;<strong>Read more</strong>&rdquo; e.g.).</li>
<li><strong>Add</strong> another <strong>property</strong> to the advertisements which should be <strong>integer</strong> &ndash; the <strong>count</strong> of <strong>views</strong> for every advert. Every advert should have <strong>0</strong> views <strong>initially</strong>. And that count will <strong>grow</strong> when someone tries to <strong>display</strong> its <strong>single</strong> view (when the &ldquo;Read more&rdquo; link is clicked).</li>
<li>Add also another <strong>string</strong> property containing <strong>link</strong> to some <strong>image</strong> (image will be used to display more information about current advert).</li>
<li>Whenever you list all the adverts, <strong>sort</strong> them <strong>by</strong> <strong>views</strong> count descending.</li>
</ol>
<p>For more clarity check the screenshots below.</p>
<h3>Screenshots</h3>
<p>We should extend the create advert functionality. Now we should have <strong>image</strong> field:</p>
<p>And when all adverts are listed: new &ldquo;Read more&rdquo; link:</p>
<p>Cool. Let&rsquo;s check the &ldquo;<strong>Read more</strong>&rdquo; out:</p>
<p>Here we have our <strong>detailed</strong> <strong>view</strong> about particular advert. What we have in addition to the previous one is that we have a <strong>photo</strong> and a <strong>views</strong> counter.</p>
<p>We should be able to <strong>change</strong> the <strong>image</strong> later on (if we want to):</p>
<h3>Hints</h3>
<ul>
<li>For the details view you can just add another section and give it some id, so you can later on refer it.</li>
<li>Then on the part where <strong>listing</strong> of adverts is done, just add another action(&lt;a&gt; tag) &ndash; next to <strong>delete</strong> and <strong>edit</strong>:</li>
</ul>
<p><br /> <strong>Create</strong> the &ldquo;Read more&rdquo; <strong>link</strong> and attach action:</p>
<p>Add it to all links:</p>
<ul>
<li><br /> The action should <strong>render</strong> some <strong>html</strong> &ndash; nothing special: some html tags with some content in it. Here is an <strong>example</strong> of how it might look like:</li>
</ul>
<p><strong>*Remember</strong> later on when you add the new properties to include them here as well.</p>
<ul>
<li>Editing an advert should now also change the <strong>image</strong> url for the advert.</li>
</ul>
<p>Note that the variables&rsquo; names might differ from the ones in your project.</p>
<h2>3.&nbsp;&nbsp; ***Add Viewcounter</h2>
<p>Your task is to extend the functionality of the above project (when completed):</p>
<ol>
<li><strong>Add</strong> another <strong>property</strong> to the advertisements which should be <strong>integer</strong> &ndash; the <strong>count</strong> of <strong>views</strong> for every advert. Every advert should have <strong>0</strong> views <strong>initially</strong>. And that count will <strong>grow</strong> when someone tries to <strong>display</strong> its <strong>single</strong> view (when the &ldquo;Read more&rdquo; link is clicked).</li>
<li>Whenever you list all the adverts, <strong>sort</strong> them by <strong>views</strong> <strong>count,</strong></li>
</ol>
<p>For more clarity check the screenshots below.</p>
<h3>Screenshots</h3>
<h3>Hints</h3>
<p>Implementing this functionality requires writing some business logic for your Kinvey app &ndash; since only the person who created an ad can modify it in the database, you can&rsquo;t just keep the views in the same object and update it when requested. Research <a href="http://devcenter.kinvey.com/rest/guides/business-logic">business logic</a> and <a href="http://devcenter.kinvey.com/rest/reference/business-logic/reference.html#collection-access-module">collection access</a> in Kinvey docs.</p>