# Command-line parameter reader (retired)
This library [is now retired and will not receive further updates](https://github.com/csf-dev/CSF.Cli.Parameters/issues/12).
Please consider [System.CommandLine](https://docs.microsoft.com/en-us/dotnet/standard/commandline/) instead.

---

This library introduces a reader/parser for command-line application parameters,
with a capability to deserialize the read parameters into a plain old CSharp
object (POCO).

To use this library you would:

* Register the available parameters using a mapping-based mechanism.
* Pass the `string[]` parameters received from your `static void Main(string[] args)` method into the parser
* Receive, from the parser, an instance of your POCO with its applicable properties populated.

## Documentation and examples
The documentation and examples for this library may be found on the [project
wiki].

[project wiki]: https://github.com/csf-dev/CSF.Cli.Parameters/wiki

## Open source license
All source files within this project are released as open source software,
under the terms of [the MIT license].

[the MIT license]: http://opensource.org/licenses/MIT

This software is distributed in the hope that it will be useful, but please
remember that:

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
