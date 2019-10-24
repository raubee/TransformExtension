# TransformExtension

- Freeze Tool - Undo/redo supported

Freezing tool is accessible in ContextMenu 

<p align="center">
  <img src="https://imgur.com/alL42XL.gif" alt="Freeze" ></img>
</p>

Also you can call it at runtime

```C#
transform.Freeze()
```

# Registry 
npmjs regisry : **com.adlucem.transform-extension**

Add these lines in *Packages/manifest.json* of your project.

```
"scopedRegistries": [
  {
    "name": "adlucem",
    "url": "https://registry.npmjs.com",
    "scopes": [
      "com.adlucem"
    ]
  }
],
"dependencies": {
  "com.adlucem.transform-extension": "X.X.X",
  ...
  }
```
