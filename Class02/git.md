# Git & Github

[<- Go Back](../README.md)

> Git is a free and open source **distributed version control system** designed to handle everything from small to very large projects with speed and efficiency.

* [Donwload and install Git](https://git-scm.com)
* After install run the following command on your terminal to check the version

```bash
git --version
```

* Current version is `2.19.0`
* [Configure git user mail](https://help.github.com/articles/setting-your-commit-email-address-in-git/)

## Using Git
* Before we start, go over the following [Git tutorial](https://try.github.io/levels/1/challenges/1)

## Configure and use Git in our local environment

* Open up git bash, and navigate to your root directory:
```bash
cd c:
```

* Create a folder with the name `proj`

```bash
mkdir proj
```

* Change directory to the newly created `proj`

```bash
cd proj
```

* Make sure you're on the right folder (`proj`)

```bash
pwd
```
* You must see the path **/c/proj/**

* At this point we can try downloading the course repository using the following command:

```bash
git clone https://github.com/kyleschmitz/dotnetwpg.git
```

* Change directory to the newly downloaded repository `dotnetwpg`
```bash
cd dotnetwpg
```

### Git Status
* **git status** shows us the working tree status, and any files that have been changed.
* [Git status doc](https://git-scm.com/docs/git-status)
* Run the following command:

```bash
git status
```

* You should see the following: `nothing to commit, working tree clean`
* You now have your own copy of the course reposity, and are free to make any changes you like, as they won't affect the other students.
* If you modify, add, or remove any files in the `dotnetwpg` folder, you can run `git status` again to see the changes.


## Git & Github Assets
* [Git Reference](https://git-scm.com/docs)
* [Git Free book](https://git-scm.com/book/en/v2)
* [Github Git cheat sheet](https://services.github.com/on-demand/downloads/github-git-cheat-sheet.pdf)
* [Visual cheat sheet](http://ndpsoftware.com/git-cheatsheet.html#loc=;)
* [Github](https://github.com)
* [Github Hello World](https://guides.github.com/activities/hello-world)
* [Github Guides](https://www.youtube.com/githubguides)
