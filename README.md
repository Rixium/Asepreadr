## Asepreadr

Asepreadr is an easy to use library for MonoGame.  
It provides utilities that can quickly read in an aseprite file an deserialize it
into an object usable in your C# code.

### Usage

Make a new instance of AsepriteSpriteMapLoader, providing it the Monogame ContentManager as an argument.

`var spriteMapLoader = new AsepriteSpriteMapLoader(Content)`

You can then use it to load an AsepriteSpriteMap, like so:

`spriteMapLoader.GetContent("Content\\My\\File.json")`

At the moment, it only works with .json files using arrays, rather than hashes, from Aseprite.

.. but, I'm open to contributions. ╰(*°▽°*)╯