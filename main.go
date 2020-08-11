package main

import (
	"fmt"
	"io/ioutil"
	"regexp"
	"strings"
)

func main() {
	loopContext, err := ioutil.ReadFile("loopcontext.txt")
	if err != nil {
		fmt.Printf("%q", err)
	}
	fmt.Println(strings.Join(regexp.MustCompile(`[A-Z]`).FindAllString(string(loopContext), -1), ""))
}
