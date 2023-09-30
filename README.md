# Overview
Basic Tic Tac Toe written in C# using Visual Studio. One player, two player, and one player IMPOSSIBLE mode. Normal one player mode has "X"s placed randomly, except in the 
case of a potential win or loss, wherein an "X" is placed to ensure (or discourage) a victory. However, there remains a %70 chance the computer will make a "mistake" and 
place an "X" elsewhere, thereby delaying its own victory or providing the player an opportunity to win. 
Impossible mode uses strategy to allow the computer to win every time, or else force a "CAT" instead.

This project was an opportunity to familiarize myself with Visual Studio and C# in general. Adapting to the language was tricky at first, but I got the hang of it. Understanding
Visual Studio was difficult, but I also felt comfortable with it by the end.

Hopefully this is a fun game to shoot some time into. And unless there's a bug, there's no way you're winning impossible mode, sorry.

[Me running through the code](https://youtu.be/2hVxKI7qH5g)

# Development Environment

I used Visual Studio 2017 and C#.

# Useful Websites

Most helpful in this project were a few youtube videos on the strategy to winning Tic Tac Toe and good old ChatGPT.

- [ChatGPT]([https://chat.openai.com/])
- [Tic Tac Toe tutorial]([(https://www.youtube.com/watch?time_continue=3&v=OmC07DvEayY&embeds_referring_euri=https%3A%2F%2Fduckduckgo.com%2F&feature=emb_title)https://www.youtube.com/watch?time_continue=3&v=OmC07DvEayY&embeds_referring_euri=https%3A%2F%2Fduckduckgo.com%2F&feature=emb_title])

# Future Work
I like the idea of a modifiable Tic Tac Toe board. It'd be interesting to be able enter in the parameters "height", "width", and "number in a row to win", and see if it could
handle the changes. It'd probably break the game, but it'd be fun.
- `Utils.cs` file, or an equivalent of it.
- Graphics, moving stuff!
- Allow player to decide to go first
