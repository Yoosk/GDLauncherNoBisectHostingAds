## This Is a Fork

Basically MultiMC wasn't allowing me to sign-in to my Mojang account anymore, GDLauncher is, but I don't like ads,
and other forks that I found are outdated so I'll try my best to remove the ads here, may be updated whenever I feel like it

## Original Project
For finding the original project quickly in case you want to:
[gorilla-devs/GDLauncher](https://github.com/gorilla-devs/GDLauncher)


## 💾 Compilation

These are the steps to compile it yourself.

### ⚙️ Requirements

You need the following software installed:

- [NodeJS](https://nodejs.org/en/download/) (> v14.14.0 x64)
- [Rust](https://www.rust-lang.org/)
- [Python2](https://www.python.org/)(Mac and linux)
- C++ compiler (g++ or windows build tools)

### ▶️ Steps

Install the dependencies and devDependencies.

```sh
$ cd GDLauncher
$ npm i
```

Start the development environment

```sh
$ npm run dev
```

For production environment...

```sh
$ npm run build && npm run start-prod
```

### 🚚 Packaging

To package the app for the local platform:

```sh
$ npm run release
```

## 🎓 License

This project is licensed under the GNU GPL V3.0 - see the [LICENSE](LICENSE) file for details.
