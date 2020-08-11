require('fs').readFile("loopcontext.txt", 'utf8', (err, loopContext) => {
  console.log(loopContext.match(/[A-Z]/g).join(""));
});
