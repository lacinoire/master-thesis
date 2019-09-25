# Validation of the labelled "BuildFailureReason", Keywords and Categories

## BuildFailureReason build log substring extraction
For each mentioned repository/buildlog here, look up the corresponding n-th log (linked). Find the reason the bulid failed, and copy paste the corresponding substring between the arrows: →←.

###
#### "n"    "repo"
#### [7    BuildFailureReason/Elixir/phoenixframework@phoenix](../tool/samples/Elixir/elixir-lang@elixir/failed/572202566.log)
→←

#### [10   BuildFailureReason/Scala/twitter@finagle](../tool/samples/Scala/twitter@finagle/failed/572992106.log)
→←

#### [4    BuildFailureReason/Java/ReactiveX@RxJava](../tool/samples/Java/ReactiveX@RxJava/failed/563267830.log)
→←

#### [7    BuildFailureReason/Haskell/purescript@purescript](../tool/samples/Haskell/purescript@purescript/failed/573124345.log)
→←

#### [1    BuildFailureReason/Erlang/erlang@otp](../tool/samples/Erlang/erlang@otp/failed/546804521.log)
→←

#### [1    BuildFailureReason/C++/bitcoin@bitcoin](../tool/samples/C++/bitcoin@bitcoin/failed/567118690.log)
→←

#### [7    BuildFailureReason/Swift/SwiftyJSON@SwiftyJSON](../tool/samples/Swift/SwiftyJSON@SwiftyJSON/failed/431817062.log)
→←

#### [2    BuildFailureReason/Python/scikit-learn@scikit-learn](../tool/samples/Python/scikit-learn@scikit-learn/failed/562396459.log)
→←

#### [3    BuildFailureReason/Rust/BurntSushi@ripgrep](../tool/samples/Rust/BurntSushi@ripgrep/failed/524430085.log)
→←

#### [5    BuildFailureReason/Erlang/processone@ejabberd](../tool/samples/Erlang/processone@ejabberd/failed/556990927.log)
→←

#### [6    BuildFailureReason/Lisp/purcell@emacs.d](../tool/samples/Lisp/purcell@emacs.d/failed/515415960.log)
→←

#### [8    BuildFailureReason/Java/iluwatar@java-design-patterns](../tool/samples/Java/iluwatar@java-design-patterns/failed/565283745.log)
→←

#### [8    BuildFailureReason/JavaScript/airbnb@javascript](../tool/samples/JavaScript/airbnb@javascript/failed/563272067.log)
→←

#### [6    BuildFailureReason/TeX/soulmachine@leetcode](../tool/samples/TeX/soulmachine@leetcode/failed/245016628.log)
→←

#### [5    BuildFailureReason/Elixir/h4cc@awesome-elixir](../tool/samples/Elixir/h4cc@awesome-elixir/failed/513586826.log)
→←

#### [6    BuildFailureReason/CSS/jgthms@bulma](../tool/samples/CSS/jgthms@bulma/failed/534204380.log)
→←

#### [5    BuildFailureReason/TypeScript/angular@angular](../tool/samples/TypeScript/angular@angular/failed/502325280.log)
→←

#### [1    BuildFailureReason/Go/ethereum@go-ethereum](../tool/samples/Go/ethereum@go-ethereum/failed/566009484.log)
→←

#### [2    BuildFailureReason/CSS/twbs@bootstrap](../tool/samples/CSS/twbs@bootstrap/failed/565973566.log)
→←

#### [5    BuildFailureReason/Swift/vsouza@awesome-ios](../tool/samples/Swift/vsouza@awesome-ios/failed/560497551.log)
→←

#### [4    BuildFailureReason/Lua/cmusatyalab@openface](../tool/samples/Lua/cmusatyalab@openface/failed/199282796.log)
→←

#### [4    BuildFailureReason/CoffeeScript/jashkenas@coffeescript](../tool/samples/CoffeeScript/jashkenas@coffeescript/failed/429651194.log)
→←

#### [3    BuildFailureReason/C#/powershell@PowerShell](../tool/samples/C#/powershell@PowerShell/failed/535987243.log)
→←

#### [6    BuildFailureReason/Clojure/technomancy@leiningen](../tool/samples/Clojure/technomancy@leiningen/failed/242689049.log)
→←

#### [1    BuildFailureReason/TypeScript/Microsoft@vscode](../tool/samples/TypeScript/Microsoft@vscode/failed/374142911.log)
→←

#### [4    BuildFailureReason/C#/NancyFx@Nancy](../tool/samples/C\#/NancyFx@Nancy/failed/382556234.log)
→←

#### [3    BuildFailureReason/Clojure/LightTable@LightTable](../tool/samples/Clojure/LightTable@LightTable/failed/557187552.log)
→←

#### [10   BuildFailureReason/PowerShell/pester@Pester](../tool/samples/PowerShell/pester@Pester/failed/572257652.log)
→←

#### [7    BuildFailureReason/Objective-C/dkhamsing@open-source-ios-apps](../tool/samples/Objective-C/dkhamsing@open-source-ios-apps/failed/562461458.log)
→←

#### [8    BuildFailureReason/Go/getlantern@lantern](../tool/samples/Go/getlantern@lantern/failed/545341186.log)
→←



## Keywords
For each mentioned repository/buildlog here, look at the extraction & context I posted here. 1-3 keywords/strings you would use to search for that area in a buildlog, and write them ', ' separated between the arrows: →←.
##### Example structure of extraction & context
```
-=-=-=-=-=--=-=-=-=-=-Example n-=-=-=-=-=--=-=-=-=-=-
Input path: xxx.log

the 10 lines before the extraction
-=-=-=-=-=-

-=-=-=-=-=-
extraction
-=-=-=-=-=-

-=-=-=-=-=-
the 10 lines after the extraction
```

#### 4    BuildFailureReason/CoffeeScript/Atom@atom
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 4-=-=-=-=-=--=-=-=-=-=-
Input path: CoffeeScript/Atom@atom/failed/544909524.log

  ․ FileRecoveryService when a crash happens during a save restores the created recovery file when many windows attempt to save the same file and one of them crashes: 6ms
    FileRecoveryService when a crash happens during a save emits a warning when a file can't be recovered: 
    parseCommandLine when --uri-handler is not passed parses arguments as normal: 
  ․ parseCommandLine when --uri-handler is not passed parses arguments as normal: 2ms
    parseCommandLine when --uri-handler is passed ignores other arguments and limits to one URL: 
  ․ parseCommandLine when --uri-handler is passed ignores other arguments and limits to one URL: 2ms

  119 passing (13s)
  1 failing

-=-=-=-=-=-

-=-=-=-=-=-
  1) AtomWindow creating a real window creates a real, properly configured BrowserWindow:
     Error: timeout of 10000ms exceeded. Ensure the done() callback is being called in this test.
-=-=-=-=-=-

-=-=-=-=-=-
  



Error! The 'core-main-process' test step finished with a non-zero exit code
travis_time:end:045e7800:start=1560371639440711287,finish=1560372509432342117,duration=869991630830
[0K[31;1mThe command "script/lint && script/build --no-bootstrap --create-debian-package --create-rpm-package --compress-artifacts && script/test
" exited with 1.[0m

travis_fold:start:cache.2
```

##### Keywords
→, , ←

#### 4    BuildFailureReason/Rust/redox-os@redox
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 4-=-=-=-=-=--=-=-=-=-=-
Input path: Rust/redox-os@redox/failed/371852012.log

[0m[0m[1m[32m   Compiling[0m gcc v0.3.54
[0m[0m[1m[32m   Compiling[0m spin v0.4.6
[0m[0m[1m[32m   Compiling[0m x86 v0.7.2
[0m[0m[1m[32m   Compiling[0m bitflags v0.7.0
[0m[0m[1m[32m   Compiling[0m plain v0.0.2
[0m[0m[1m[32m   Compiling[0m kernel v0.1.33 (file:///home/travis/build/redox-os/redox/kernel)
[0m[0m[1m[32m   Compiling[0m scroll v0.5.0
[0m[0m[1m[32m   Compiling[0m bitflags v1.0.1
[0m[0m[1m[32m   Compiling[0m redox_syscall v0.1.37 (file:///home/travis/build/redox-os/redox/kernel/syscall)
[0m[0m[1m[32m   Compiling[0m linked_list_allocator v0.5.0
-=-=-=-=-=-

-=-=-=-=-=-
[0m[1m[38;5;9merror[E0407][0m[0m[1m: method `oom` is not a member of trait `Alloc`[0m
[0m   [0m[0m[1m[38;5;12m--> [0m[0m/home/travis/.cargo/registry/src/github.com-1ecc6299db9ec823/linked_list_allocator-0.5.0/src/lib.rs:139:5[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m[1m[38;5;12m139[0m[0m [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m/[0m[0m [0m[0m    fn oom(&mut self, _: AllocErr) -> ! {[0m
[0m[1m[38;5;12m140[0m[0m [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m|[0m[0m [0m[0m        panic!("Out of memory");[0m
[0m[1m[38;5;12m141[0m[0m [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m|[0m[0m [0m[0m    }[0m
[0m    [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m|_____^[0m[0m [0m[0m[1m[38;5;9mnot a member of trait `Alloc`[0m

[0m[1m[38;5;9merror[E0407][0m[0m[1m: method `oom` is not a member of trait `Alloc`[0m
[0m   [0m[0m[1m[38;5;12m--> [0m[0m/home/travis/.cargo/registry/src/github.com-1ecc6299db9ec823/linked_list_allocator-0.5.0/src/lib.rs:186:5[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m[1m[38;5;12m186[0m[0m [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m/[0m[0m [0m[0m    fn oom(&mut self, _: AllocErr) -> ! {[0m
[0m[1m[38;5;12m187[0m[0m [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m|[0m[0m [0m[0m        panic!("Out of memory");[0m
[0m[1m[38;5;12m188[0m[0m [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m|[0m[0m [0m[0m    }[0m
[0m    [0m[0m[1m[38;5;12m| [0m[0m[1m[38;5;9m|_____^[0m[0m [0m[0m[1m[38;5;9mnot a member of trait `Alloc`[0m

[0m[1m[38;5;9merror[E0053][0m[0m[1m: method `alloc` has an incompatible type for trait[0m
[0m   [0m[0m[1m[38;5;12m--> [0m[0m/home/travis/.cargo/registry/src/github.com-1ecc6299db9ec823/linked_list_allocator-0.5.0/src/lib.rs:131:5[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m[1m[38;5;12m131[0m[0m [0m[0m[1m[38;5;12m| [0m[0m    unsafe fn alloc(&mut self, layout: Layout) -> Result<*mut u8, AllocErr> {[0m
[0m    [0m[0m[1m[38;5;12m| [0m[0m    [0m[0m[1m[38;5;9m^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[0m[0m [0m[0m[1m[38;5;9mexpected struct `core::ptr::NonNull`, found *-ptr[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m    [0m[0m[1m[38;5;12m= [0m[0m[1mnote[0m[0m: expected type `[0m[0m[1munsafe fn(&mut Heap, core::alloc::Layout) -> core::result::Result<core::ptr::NonNull<core::alloc::Opaque>, core::alloc::AllocErr>[0m[0m`[0m
[0m               found type `[0m[0m[1munsafe fn(&mut Heap, core::alloc::Layout) -> core::result::Result<*mut u8, core::alloc::AllocErr>[0m[0m`[0m

[0m[1m[38;5;9merror[E0053][0m[0m[1m: method `dealloc` has an incompatible type for trait[0m
[0m   [0m[0m[1m[38;5;12m--> [0m[0m/home/travis/.cargo/registry/src/github.com-1ecc6299db9ec823/linked_list_allocator-0.5.0/src/lib.rs:135:5[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m[1m[38;5;12m135[0m[0m [0m[0m[1m[38;5;12m| [0m[0m    unsafe fn dealloc(&mut self, ptr: *mut u8, layout: Layout) {[0m
[0m    [0m[0m[1m[38;5;12m| [0m[0m    [0m[0m[1m[38;5;9m^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[0m[0m [0m[0m[1m[38;5;9mexpected struct `core::ptr::NonNull`, found *-ptr[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m    [0m[0m[1m[38;5;12m= [0m[0m[1mnote[0m[0m: expected type `[0m[0m[1munsafe fn(&mut Heap, core::ptr::NonNull<core::alloc::Opaque>, core::alloc::Layout)[0m[0m`[0m
[0m               found type `[0m[0m[1munsafe fn(&mut Heap, *mut u8, core::alloc::Layout)[0m[0m`[0m

[0m[1m[38;5;9merror[E0053][0m[0m[1m: method `alloc` has an incompatible type for trait[0m
[0m   [0m[0m[1m[38;5;12m--> [0m[0m/home/travis/.cargo/registry/src/github.com-1ecc6299db9ec823/linked_list_allocator-0.5.0/src/lib.rs:178:5[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m[1m[38;5;12m178[0m[0m [0m[0m[1m[38;5;12m| [0m[0m    unsafe fn alloc(&mut self, layout: Layout) -> Result<*mut u8, AllocErr> {[0m
[0m    [0m[0m[1m[38;5;12m| [0m[0m    [0m[0m[1m[38;5;9m^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[0m[0m [0m[0m[1m[38;5;9mexpected struct `core::ptr::NonNull`, found *-ptr[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m    [0m[0m[1m[38;5;12m= [0m[0m[1mnote[0m[0m: expected type `[0m[0m[1munsafe fn(&mut &'a LockedHeap, core::alloc::Layout) -> core::result::Result<core::ptr::NonNull<core::alloc::Opaque>, core::alloc::AllocErr>[0m[0m`[0m
[0m               found type `[0m[0m[1munsafe fn(&mut &'a LockedHeap, core::alloc::Layout) -> core::result::Result<*mut u8, core::alloc::AllocErr>[0m[0m`[0m

[0m[1m[38;5;9merror[E0053][0m[0m[1m: method `dealloc` has an incompatible type for trait[0m
[0m   [0m[0m[1m[38;5;12m--> [0m[0m/home/travis/.cargo/registry/src/github.com-1ecc6299db9ec823/linked_list_allocator-0.5.0/src/lib.rs:182:5[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m[1m[38;5;12m182[0m[0m [0m[0m[1m[38;5;12m| [0m[0m    unsafe fn dealloc(&mut self, ptr: *mut u8, layout: Layout) {[0m
[0m    [0m[0m[1m[38;5;12m| [0m[0m    [0m[0m[1m[38;5;9m^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[0m[0m [0m[0m[1m[38;5;9mexpected struct `core::ptr::NonNull`, found *-ptr[0m
[0m    [0m[0m[1m[38;5;12m|[0m
[0m    [0m[0m[1m[38;5;12m= [0m[0m[1mnote[0m[0m: expected type `[0m[0m[1munsafe fn(&mut &'a LockedHeap, core::ptr::NonNull<core::alloc::Opaque>, core::alloc::Layout)[0m[0m`[0m
[0m               found type `[0m[0m[1munsafe fn(&mut &'a LockedHeap, *mut u8, core::alloc::Layout)[0m[0m`[0m
-=-=-=-=-=-

-=-=-=-=-=-

[0m[1m[38;5;9merror[0m[0m[1m: aborting due to 6 previous errors[0m

[0m[1mSome errors occurred: E0053, E0407.[0m
[0m[1mFor more information about an error, try `rustc --explain E0053`.[0m
[0m[0m[1m[31merror:[0m Could not compile `linked_list_allocator`.
[0m[0m[1m[33mwarning:[0m build failed, waiting for other jobs to finish...
[0m[0m[1m[31merror:[0m build failed
make[1]: *** [build/libkernel.a] Error 101
make[1]: Leaving directory `/home/travis/build/redox-os/redox'
```

##### Keywords
→, , ←

#### 3    BuildFailureReason/Lua/luvit@luvit
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Lua/luvit@luvit/failed/232600805.log

fetching: 3 objects

using snapshot: [1;36;44m31b8c996c762b151bedbd7f0e5ad12c2ababf3cd[0m

creating binary: [1;36;44m/home/travis/build/luvit/luvit/luvit[0m

using luvi from: [1;36;44m/home/travis/build/luvit/luvit/luvi[0m

fetching: 1 object

-=-=-=-=-=-

-=-=-=-=-=-
fail: [1;33;41m[string "bundle:libs/codec.lua"]:123: No such hash: 31b8c996c762b151bedbd7f0e5ad12c2ababf3cd

stack traceback:

	[C]: in function 'assert'

	[string "bundle:libs/codec.lua"]:123: in function 'read'

	[string "bundle:libs/codec.lua"]:128: in function 'readAs'

	[string "bundle:libs/rdb.lua"]:165: in function 'fetch'

	[string "bundle:libs/rdb.lua"]:140: in function 'load'

	[string "bundle:deps/git/db.lua"]:395: in function 'loadAny'

	[string "bundle:libs/pkg.lua"]:132: in function 'queryDb'

	[string "bundle:libs/core.lua"]:378: in function 'makeUrl'

	[string "bundle:commands/make.lua"]:13: in function <[string "bundle:commands/make.lua"]:1>

	[string "bundle:main.lua"]:52: in function <[string "bundle:main.lua"]:39>

	[C]: in function 'xpcall'

	[string "bundle:main.lua"]:39: in function <[string "bundle:main.lua"]:31>[0m
-=-=-=-=-=-

-=-=-=-=-=-


make: *** [lit] Error 255


travis_time:end:0893ba80:start=1494884096579313719,finish=1494884098554894368,duration=1975580649
[0K

[31;1mThe command "make" exited with 2.[0m
```

##### Keywords
→, , ←

#### 9    BuildFailureReason/Ruby/rails@rails
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 9-=-=-=-=-=--=-=-=-=-=-
Input path: Ruby/rails@rails/failed/517367909.log


[1;33m[Travis CI] actioncable[m
Running command: bundle exec rake test
/home/travis/.rvm/rubies/ruby-2.3.8/bin/ruby -w -I"lib:test" -I"/home/travis/build/rails/rails/vendor/bundle/ruby/2.3.0/gems/rake-12.3.2/lib" "/home/travis/build/rails/rails/vendor/bundle/ruby/2.3.0/gems/rake-12.3.2/lib/rake/rake_test_loader.rb" "/home/travis/build/rails/rails/actioncable/test/server/base_test.rb" "/home/travis/build/rails/rails/actioncable/test/server/broadcasting_test.rb" "/home/travis/build/rails/rails/actioncable/test/channel/rejection_test.rb" "/home/travis/build/rails/rails/actioncable/test/channel/base_test.rb" "/home/travis/build/rails/rails/actioncable/test/channel/periodic_timers_test.rb" "/home/travis/build/rails/rails/actioncable/test/channel/stream_test.rb" "/home/travis/build/rails/rails/actioncable/test/channel/naming_test.rb" "/home/travis/build/rails/rails/actioncable/test/channel/broadcasting_test.rb" "/home/travis/build/rails/rails/actioncable/test/client_test.rb" "/home/travis/build/rails/rails/actioncable/test/subscription_adapter/evented_redis_test.rb" "/home/travis/build/rails/rails/actioncable/test/subscription_adapter/base_test.rb" "/home/travis/build/rails/rails/actioncable/test/subscription_adapter/subscriber_map_test.rb" "/home/travis/build/rails/rails/actioncable/test/subscription_adapter/inline_test.rb" "/home/travis/build/rails/rails/actioncable/test/subscription_adapter/async_test.rb" "/home/travis/build/rails/rails/actioncable/test/subscription_adapter/redis_test.rb" "/home/travis/build/rails/rails/actioncable/test/subscription_adapter/postgresql_test.rb" "/home/travis/build/rails/rails/actioncable/test/worker_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/base_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/client_socket_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/identifier_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/multiple_identifiers_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/cross_site_forgery_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/string_identifier_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/authorization_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/stream_test.rb" "/home/travis/build/rails/rails/actioncable/test/connection/subscriptions_test.rb" 
Run options: --seed 34606

# Running:

................................................E

-=-=-=-=-=-

-=-=-=-=-=-
Error:
ClientTest#test_unsubscribe_client:
RuntimeError: 1 messages unprocessed
    /home/travis/build/rails/rails/actioncable/test/client_test.rb:170:in `close'
    /home/travis/build/rails/rails/actioncable/test/client_test.rb:276:in `block in test_unsubscribe_client'
    /home/travis/build/rails/rails/actioncable/test/client_test.rb:68:in `with_puma_server'
    /home/travis/build/rails/rails/actioncable/test/client_test.rb:261:in `test_unsubscribe_client'
-=-=-=-=-=-

-=-=-=-=-=-

bin/rails test home/travis/build/rails/rails/actioncable/test/client_test.rb:260

.E

Error:
ClientTest#test_many_clients:
ThreadError: queue empty
    /home/travis/build/rails/rails/actioncable/test/client_test.rb:141:in `pop'
    /home/travis/build/rails/rails/actioncable/test/client_test.rb:141:in `read_message'
```

##### Keywords
→, , ←

#### 5    BuildFailureReason/Ruby/discourse@discourse
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 5-=-=-=-=-=--=-=-=-=-=-
Input path: Ruby/discourse@discourse/failed/566028969.log


[36m
  EXECUTE >[0m [1meslint-assets[0m
[2K[1G[1myarn run v1.3.2[22m

(node:11394) [DEP0005] DeprecationWarning: Buffer() is deprecated due to security and usability issues. Please use the Buffer.alloc(), Buffer.allocUnsafe(), or Buffer.from() methods instead.

[2K[1G[2m$ /home/travis/build/discourse/discourse/node_modules/.bin/eslint --ext .es6 app/assets/javascripts[22m


-=-=-=-=-=-

-=-=-=-=-=-
[4m/home/travis/build/discourse/discourse/app/assets/javascripts/discourse/controllers/preferences/users.js.es6[24m

  [2m3:8[22m  [31merror[39m  'showModal' is defined but never used  [2mno-unused-vars[22m

  [2m4:8[22m  [31merror[39m  'User' is defined but never used       [2mno-unused-vars[22m
-=-=-=-=-=-

-=-=-=-=-=-


[31m[1m✖ 2 problems (2 errors, 0 warnings)[22m[39m

[31m[1m[22m[39m

[2K[1G[31merror[39m Command failed with exit code 1.

[2K[1G[34minfo[39m Visit [1mhttps://yarnpkg.com/en/docs/cli/run[22m for documentation about this command.
```

##### Keywords
→, , ←

#### 5    BuildFailureReason/HTML/google@web-starter-kit
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 5-=-=-=-=-=--=-=-=-=-=-
Input path: HTML/google@web-starter-kit/failed/348097360.log

[[90m05:29:26[39m] Finished '[36mscripts: scripts/register-service-worker.js[39m' after [35m8.74 s[39m
[[90m05:29:27[39m] Finished '[36mcss[39m' after [35m9.69 s[39m
[[90m05:29:28[39m] gulp-imagemin: Minified 3 images[90m (saved 13.9 kB - 1.9%)[39m
[[90m05:29:28[39m] Finished '[36mimages[39m' after [35m11 s[39m
[[90m05:29:28[39m] Finished '[36mbuild[39m' after [35m11 s[39m

> @ lint /home/travis/build/google/web-starter-kit
> eslint '.' --ignore-path .gitignore


-=-=-=-=-=-

-=-=-=-=-=-
[4m/home/travis/build/google/web-starter-kit/gulp-tasks/css.js[24m
  [2m12:2[22m  [31merror[39m  Unnecessary semicolon  [2mno-extra-semi[22m

[4m/home/travis/build/google/web-starter-kit/gulp-tasks/images.js[24m
  [2m16:2[22m  [31merror[39m  Unnecessary semicolon  [2mno-extra-semi[22m

[4m/home/travis/build/google/web-starter-kit/gulp-tasks/serviceWorker.js[24m
  [2m4:16[22m  [31merror[39m  'serviceWorker' is defined but never used  [2mno-unused-vars[22m
-=-=-=-=-=-

-=-=-=-=-=-

[31m[1m✖ 3 problems (3 errors, 0 warnings)[22m[39m
[31m[1m[22m[39m[31m[1m  2 errors, 0 warnings potentially fixable with the `--fix` option.[22m[39m
[31m[1m[22m[39m
[37;40mnpm[0m [0m[31;40mERR![0m [0m[35mcode[0m ELIFECYCLE
[0m[37;40mnpm[0m [0m[31;40mERR![0m [0m[35merrno[0m 1
[0m[37;40mnpm[0m [0m[31;40mERR![0m[35m[0m @ lint: `eslint '.' --ignore-path .gitignore`
[0m[37;40mnpm[0m [0m[31;40mERR![0m[35m[0m Exit status 1
[0m[37;40mnpm[0m [0m[31;40mERR![0m[35m[0m 
[0m[37;40mnpm[0m [0m[31;40mERR![0m[35m[0m Failed at the @ lint script.
```

##### Keywords
→, , ←

#### 9    BuildFailureReason/R/rstudio@shiny
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 9-=-=-=-=-=--=-=-=-=-=-
Input path: R/rstudio@shiny/failed/575521370.log

File [36m../inst/www/shared/datepicker/js/bootstrap-datepicker.min.js[39m created: [32m90.41 kB[39m → [32m65.55 kB[39m
[32m>> [39m1 file created.

[4mRunning "newer-postrun:uglify:datepicker:6:/home/travis/build/rstudio/shiny/tools/node_modules/grunt-newer/.cache" (newer-postrun) task[24m

[4mRunning "newer:uglify:ionrangeslider" (newer) task[24m
No newer files to process.

[32mDone.[39m
[2K[1GDone in 6.63s.
-=-=-=-=-=-

-=-=-=-=-=-
 M inst/www/shared/shiny.js
 M inst/www/shared/shiny.min.js
Please rebuild the JavaScript and commit the changes.
The above files changed when we built the JavaScript assets. This most often occurs when a user makes changes to the JavaScript sources but doesn't rebuild and commit them.
-=-=-=-=-=-

-=-=-=-=-=-
travis_time:end:0af98d9e:start=1566505335013214390,finish=1566505346488777279,duration=11475562889
[0K[31;1mThe command "./tools/checkJSCurrent.sh" exited with 1.[0m

travis_fold:start:cache.2
[0Kstore build cache
travis_time:start:093233f0
[0Ktravis_time:end:093233f0:start=1566505346494512713,finish=1566505346498375752,duration=3863039
[0Ktravis_time:start:0e4f2050
[0K[32;1mnothing changed[0m
travis_time:end:0e4f2050:start=1566505346503307705,finish=1566505348319267283,duration=1815959578
```

##### Keywords
→, , ←

#### 4    BuildFailureReason/TeX/cplusplus@draft
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 4-=-=-=-=-=--=-=-=-=-=-
Input path: TeX/cplusplus@draft/failed/566261609.log

 restricted \write18 enabled.
entering extended mode
Latexmk: Run number 4 of rule 'pdflatex'
This is pdfTeX, Version 3.14159265-2.6-1.40.16 (TeX Live 2015/Debian) (preloaded format=pdflatex)
 restricted \write18 enabled.
entering extended mode
Latexmk: Run number 5 of rule 'pdflatex'
This is pdfTeX, Version 3.14159265-2.6-1.40.16 (TeX Live 2015/Debian) (preloaded format=pdflatex)
 restricted \write18 enabled.
entering extended mode
-=-=-=-=-=-

-=-=-=-=-=-
Overfull \hbox (2.26166pt too wide) in paragraph at lines 4826--4842
-=-=-=-=-=-

-=-=-=-=-=-
travis_time:end:02228d21:start=1564624026208235719,finish=1564624204272156885,duration=178063921166
[0K[31;1mThe command "if [ "$BUILD_TYPE" = "latexmk" ]; then docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && latexmk -pdf std -silent"; ! grep -Fe "Overfull \hbox" std.log && ! grep "LaTeX Warning..There were undefined references" std.log; fi" exited with 1.[0m

travis_time:start:11418c78
[0K$ if [ "$BUILD_TYPE" = "make" ]; then docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && make -j2"; fi
travis_time:end:11418c78:start=1564624204278211273,finish=1564624204282017914,duration=3806641
[0K[32;1mThe command "if [ "$BUILD_TYPE" = "make" ]; then docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && make -j2"; fi" exited with 0.[0m

travis_time:start:0d5a0e19
[0K$ if [ "$BUILD_TYPE" = "complete" ]; then for FIGURE in *.dot; do docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && dot -o$(basename $FIGURE .dot).pdf -Tpdf $FIGURE"; done; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && pdflatex std"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && pdflatex std"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && pdflatex std"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && makeindex generalindex"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && makeindex libraryindex"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && makeindex grammarindex"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && makeindex impldefindex"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && pdflatex std"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && makeindex -s basic.gst -o xrefindex.gls xrefindex.glo"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && makeindex -s basic.gst -o xrefdelta.gls xrefdelta.glo"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && pdflatex std"; docker exec -it texlive-basic bash -c "cd /$TRAVIS_REPO_SLUG/source && pdflatex std"; fi
```

##### Keywords
→, , ←

#### 8    BuildFailureReason/TeX/adambard@learnxinyminutes-docs
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 8-=-=-=-=-=--=-=-=-=-=-
Input path: TeX/adambard@learnxinyminutes-docs/failed/559642811.log

travis_time:start:0a20c310
[0K$ bundle exec rake
/home/travis/.rvm/rubies/ruby-2.2.7/bin/ruby tests/encoding.rb
Notice: ./ro-ro/ruby-ro.html.markdown was detected as ISO-8859-2 encoding. Everything is probably fine.
Notice: ./ro-ro/coffeescript-ro.html.markdown was detected as ISO-8859-2 encoding. Everything is probably fine.
Notice: ./ro-ro/clojure-ro.html.markdown was detected as ISO-8859-2 encoding. Everything is probably fine.
Notice: ./id-id/bf-id.html.markdown was detected as ISO-8859-9 encoding. Everything is probably fine.
Notice: ./id-id/markdown.html.markdown was detected as ISO-8859-9 encoding. Everything is probably fine.
Success. All 672 files passed UTF-8 validity checks.
/home/travis/.rvm/rubies/ruby-2.2.7/bin/ruby tests/yaml.rb
-=-=-=-=-=-

-=-=-=-=-=-
(./th-th/pascal.th.html.markdown): found character that cannot start any token while scanning for the next token at line 5 column 1
-=-=-=-=-=-

-=-=-=-=-=-
FAILURE!!! 1 files were unable to be parsed!
Please check the YAML headers for the documents that failed!
Command failed with status (1): [/home/travis/.rvm/rubies/ruby-2.2.7/bin/ru...]
rake aborted!
Failed 1 tests!!
/home/travis/build/adambard/learnxinyminutes-docs/Rakefile:21:in `block in <top (required)>'
/home/travis/build/adambard/learnxinyminutes-docs/vendor/bundle/ruby/2.2.0/gems/rake-12.0.0/exe/rake:27:in `<top (required)>'
/home/travis/.rvm/gems/ruby-2.2.7/bin/bundle:23:in `load'
/home/travis/.rvm/gems/ruby-2.2.7/bin/bundle:23:in `<main>'
Tasks: TOP => default => return_code
```

##### Keywords
→, , ←

#### 3    BuildFailureReason/JavaScript/FreeCodeCamp@freecodecamp
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: JavaScript/FreeCodeCamp@freecodecamp/failed/566340191.log

> mocha --delay --reporter progress --bail

Browserslist: caniuse-lite is outdated. Please run next command `npm update caniuse-lite browserslist`

[J  [․․․․․․․․․․․․․․․․․․․․․․․․․․․․․․․․․․․․]

  2109 passing (1m)
  6 pending
  1 failing

-=-=-=-=-=-

-=-=-=-=-=-
  1) Check challenges
       Check challenges (english)
         Use Recursion to Create a Range of Numbers
           Check tests against solutions
             Solution 1:
     Error: the string "<code>rangeOfNumbers(1, 5)</code> should return <code>[1, 2, 3, 4, 5]</code>.\n        <code>rangeOfNumbers(1, 5)</code> should return <code>[1, 2, 3, 4, 5]</code>.\nassert.deepStrictEqual is not a function" was thrown, throw an Error :)
      at Runner.Mocha.Runner.fail (test/test-challenges.js:65:24)
      at process._tickCallback (internal/process/next_tick.js:68:7)
-=-=-=-=-=-

-=-=-=-=-=-



npm ERR! Test failed.  See above for more details.
npm ERR! code ELIFECYCLE
npm ERR! errno 1
npm ERR! @freecodecamp/freecodecamp@0.0.1 test:curriculum: `cd ./curriculum && npm test && cd ../`
npm ERR! Exit status 1
npm ERR! 
npm ERR! Failed at the @freecodecamp/freecodecamp@0.0.1 test:curriculum script.
```

##### Keywords
→, , ←

#### 6    BuildFailureReason/CSS/google@material-design-icons
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 6-=-=-=-=-=--=-=-=-=-=-
Input path: CSS/google@material-design-icons/failed/93320805.log

ruby 1.9.3p551 (2014-11-13 revision 48407) [x86_64-linux]
$ rvm --version
rvm 1.26.10 (latest-minor) by Wayne E. Seguin <wayneeseguin@gmail.com>, Michal Papis <mpapis@gmail.com> [https://rvm.io/]
$ bundle --version
Bundler version 1.7.6
$ gem --version
2.4.5
travis_time:start:09c63f00
[0K$ rake
rake aborted!
-=-=-=-=-=-

-=-=-=-=-=-
No Rakefile found (looking for: rakefile, Rakefile, rakefile.rb, Rakefile.rb)
/home/travis/.rvm/gems/ruby-1.9.3-p551/bin/ruby_executable_hooks:15:in `eval'
/home/travis/.rvm/gems/ruby-1.9.3-p551/bin/ruby_executable_hooks:15:in `<main>'
-=-=-=-=-=-

-=-=-=-=-=-
(See full trace by running task with --trace)
travis_time:end:09c63f00:start=1448529597848790205,finish=1448529597975088347,duration=126298142
[0K
[31;1mThe command "rake" exited with 1.[0m

Done. Your build exited with 1.
```

##### Keywords
→, , ←

#### 10   BuildFailureReason/CoffeeScript/postcss@autoprefixer
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 10-=-=-=-=-=--=-=-=-=-=-
Input path: CoffeeScript/postcss@autoprefixer/failed/554480449.log

[[90m01:30:10[39m] Finished '[36mclean[39m' after [35m49 ms[39m
[[90m01:30:10[39m] Starting '[36m<anonymous>[39m'...
[[90m01:30:11[39m] Finished '[36mbuild:bin[39m' after [35m914 ms[39m
[[90m01:30:11[39m] Finished '[36mbuild:package[39m' after [35m916 ms[39m
[[90m01:30:11[39m] Finished '[36mbuild:docs[39m' after [35m1.41 s[39m
[[90m01:30:14[39m] Finished '[36m<anonymous>[39m' after [35m3.57 s[39m
[[90m01:30:14[39m] Finished '[36mbuild:lib[39m' after [35m3.62 s[39m
[[90m01:30:14[39m] Finished '[36mbuild[39m' after [35m3.62 s[39m
[[90m01:30:14[39m] Finished '[36mdefault[39m' after [35m3.62 s[39m

-=-=-=-=-=-

-=-=-=-=-=-
  [31mPackage size limit has exceeded by 624 B[39m
  Size limit:   [1m110 KB[22m
  Package size: [31m[1m110.61 KB[22m[39m [90mwith all dependencies, minified and gzipped[39m
-=-=-=-=-=-

-=-=-=-=-=-
  Loading time: [31m[1m2.3 s    [22m[39m [90mon slow 3G[39m
  Running time: [31m[1m5.1 s    [22m[39m [90mon Snapdragon 410[39m
  Total time:   [31m[1m7.3 s[22m[39m

  [33mTry to reduce size or increase limit in [1m"size-limit"[22m section of [1mpackage.json[22m[39m
[2K[1G[31merror[39m Command failed with exit code 3.
[2K[1G[34minfo[39m Visit [1mhttps://yarnpkg.com/en/docs/cli/run[22m for documentation about this command.
travis_time:end:0c46979e:start=1562290189074795360,finish=1562290227622341454,duration=38547546094
[0K[31;1mThe command "yarn test" exited with 1.[0m
```

##### Keywords
→, , ←

#### 3    BuildFailureReason/PHP/symfony@symfony
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: PHP/symfony@symfony/failed/567032141.log

#!/usr/bin/env php
PHPUnit 6.5.14 by Sebastian Bergmann and contributors.

Testing Symfony PHPUnit Bridge Test Suite
...[41;37mF[0m[41;37mF[0m[41;37mF[0m[41;37mF[0m[41;37mF[0m[41;37mF[0m[41;37mF[0m...............................[36;1mS[0m.................       59 / 59 (100%)

Time: 3.09 seconds, Memory: 4.00MB

There were 7 failures:

-=-=-=-=-=-

-=-=-=-=-=-
1) Symfony\Bridge\PhpUnit\Tests\ClockMockTest::testTime
Failed asserting that 1564764243 is identical to 1234567890.

2) Symfony\Bridge\PhpUnit\Tests\ClockMockTest::testSleep
Failed asserting that 1564764245 is identical to 1234567892.

3) Symfony\Bridge\PhpUnit\Tests\ClockMockTest::testMicrotime
Failed asserting that two strings are identical.
--- Expected
+++ Actual
@@ @@
-'0.12500000 1234567890'
+'0.25615200 1564764245'

4) Symfony\Bridge\PhpUnit\Tests\ClockMockTest::testMicrotimeAsFloat
Failed asserting that 1564764245.25681 is identical to 1234567890.125.

5) Symfony\Bridge\PhpUnit\Tests\ClockMockTest::testUsleep
Failed asserting that 1564764245.257137 is identical to 1234567890.125002.

6) Symfony\Bridge\PhpUnit\Tests\ClockMockTest::testDate
Failed asserting that two strings are identical.
--- Expected
+++ Actual
@@ @@
-'1234567890'
+'1564764245'

7) Symfony\Bridge\PhpUnit\Tests\ClockMockTest::testGmDate
Failed asserting that two strings are identical.
--- Expected
+++ Actual
@@ @@
-'1555075769'
+'1564764245'
-=-=-=-=-=-

-=-=-=-=-=-

[37;41mFAILURES![0m
[37;41mTests: 59[0m[37;41m, Assertions: 139[0m[37;41m, Failures: 7[0m[37;41m, Skipped: 1[0m[37;41m.[0m

travis_time:end:2433ff6f:start=1564764240287006866,finish=1564764246304258960,duration=6017252094
[41mKO[0m 🐘 7.2 src/Symfony/Bridge/PhpUnit
```

##### Keywords
→, , ←

#### 3    BuildFailureReason/C++/electron@electron
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: C++/electron@electron/failed/303153628.log

husky
CI detected, skipping Git hooks installation

> dugite@1.49.0 postinstall /home/travis/build/electron/electron/node_modules/dugite
> node ./script/download-git.js

module.js:327
    throw err;
    ^

-=-=-=-=-=-

-=-=-=-=-=-
Error: Cannot find module 'fast-deep-equal'
    at Function.Module._resolveFilename (module.js:325:15)
    at Function.Module._load (module.js:276:25)
    at Module.require (module.js:353:17)
    at require (internal/module.js:12:17)
    at Object.<anonymous> (/home/travis/build/electron/electron/node_modules/request/node_modules/har-validator/node_modules/ajv/lib/compile/resolve.js:4:13)
    at Module._compile (module.js:409:26)
    at Object.Module._extensions..js (module.js:416:10)
    at Module.load (module.js:343:32)
    at Function.Module._load (module.js:300:12)
    at Module.require (module.js:353:17)
-=-=-=-=-=-

-=-=-=-=-=-
[37m[40mnpm[0m [0m[31m[40mERR![0m[35m[0m Linux 4.4.0-93-generic
[0m[37m[40mnpm[0m [0m[31m[40mERR![0m [0m[35margv[0m "/home/travis/.nvm/versions/node/v4.8.6/bin/node" "/home/travis/.nvm/versions/node/v4.8.6/bin/npm" "install"
[0m[37m[40mnpm[0m [0m[31m[40mERR![0m [0m[35mnode[0m v4.8.6
[0m[37m[40mnpm[0m [0m[31m[40mERR![0m [0m[35mnpm [0m v2.15.11
[0m[37m[40mnpm[0m [0m[31m[40mERR![0m [0m[35mcode[0m ELIFECYCLE
[0m
[37m[40mnpm[0m [0m[31m[40mERR![0m[35m[0m dugite@1.49.0 postinstall: `node ./script/download-git.js`
[0m[37m[40mnpm[0m [0m[31m[40mERR![0m[35m[0m Exit status 1
[0m[37m[40mnpm[0m [0m[31m[40mERR![0m[35m[0m 
[0m[37m[40mnpm[0m [0m[31m[40mERR![0m[35m[0m Failed at the dugite@1.49.0 postinstall script 'node ./script/download-git.js'.
```

##### Keywords
→, , ←

#### 7    BuildFailureReason/VimL/mhinz@vim-galore
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 7-=-=-=-=-=--=-=-=-=-=-
Input path: VimL/mhinz@vim-galore/failed/403259414.log

CGO_LDFLAGS="-g -O2"
travis_fold:end:go.env
[0Ktravis_fold:start:install
[0Ktravis_time:start:1bc1d46f
[0K$ go get github.com/mhinz/gomali

travis_time:end:1bc1d46f:start=1531422831277618870,finish=1531422831813830289,duration=536211419
[0Ktravis_fold:end:install
[0Ktravis_time:start:20c5bd5c
[0K$ gomali *.md
-=-=-=-=-=-

-=-=-=-=-=-
README.md:2192:Line longer than 80 characters.
-=-=-=-=-=-

-=-=-=-=-=-

travis_time:end:20c5bd5c:start=1531422831819422676,finish=1531422831828030198,duration=8607522
[0K
[31;1mThe command "gomali *.md" exited with 1.[0m

Done. Your build exited with 1.
```

##### Keywords
→, , ←

#### 5    BuildFailureReason/VimL/neovim@neovim
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 5-=-=-=-=-=--=-=-=-=-=-
Input path: VimL/neovim@neovim/failed/567681970.log

[32m[2m[ RUN      ][0m[0m health.vim :checkhealth concatenates multiple reports: [2m307.35 ms[0m [1m[32mOK[0m[0m
[32m[2m[ RUN      ][0m[0m health.vim :checkhealth gracefully handles broken healthcheck: [2m290.40 ms[0m [1m[32mOK[0m[0m
[32m[2m[ RUN      ][0m[0m health.vim :checkhealth highlights OK, ERROR: [2m331.00 ms[0m [1m[32mOK[0m[0m
[32m[2m[ RUN      ][0m[0m health.vim :checkhealth gracefully handles invalid healthcheck: [2m288.78 ms[0m [1m[32mOK[0m[0m
[32m[2m[----------][0m[0m [1m9[0m tests from [36mtest/functional/plugin/health_spec.lua[0m [2m(2582.94 ms total)[0m

[32m[2m[----------][0m[0m Running tests from [36mtest/functional/plugin/man_spec.lua[0m
[32m[2m[ RUN      ][0m[0m :Man man.lua: highlight_line() clears backspaces from text and adds highlights: [2m18.69 ms[0m [1m[32mOK[0m[0m
==================== File /home/travis/build/neovim/neovim/build/log/ubsan.16550 ====================
= =================================================================
-=-=-=-=-=-

-=-=-=-=-=-
= ==16550==ERROR: AddressSanitizer: SEGV on unknown address 0x000001d548d0 (pc 0x000000455084 bp 0x000000000000 sp 0x7fffab6f2bd0 T0)
= ==16550==The signal is caused by a WRITE memory access.
=     #0 0x455083 in atomic_compare_exchange_strong<__sanitizer::atomic_uint8_t> /tmp/final/llvm.src/projects/compiler-rt/lib/asan/../sanitizer_common/sanitizer_atomic_clang.h:81:10
=     #1 0x455083 in AtomicallySetQuarantineFlagIfAllocated /tmp/final/llvm.src/projects/compiler-rt/lib/asan/asan_allocator.cc:554
=     #2 0x455083 in __asan::Allocator::Deallocate(void*, unsigned long, unsigned long, __sanitizer::BufferedStackTrace*, __asan::AllocType) /tmp/final/llvm.src/projects/compiler-rt/lib/asan/asan_allocator.cc:631
=     #3 0x4fb97b in __interceptor_free /tmp/final/llvm.src/projects/compiler-rt/lib/asan/asan_malloc_linux.cc:129:3
=     #4 0x1066974 in xfree /home/travis/build/neovim/neovim/build/../src/nvim/memory.c:119:3
=     #5 0x12c54b8 in free_string_option /home/travis/build/neovim/neovim/build/../src/nvim/option.c:2306:5
=     #6 0x12c49dd in free_all_options /home/travis/build/neovim/neovim/build/../src/nvim/option.c:969:9
=     #7 0x1069609 in free_all_mem /home/travis/build/neovim/neovim/build/../src/nvim/memory.c:650:3
=     #8 0x1378f95 in mch_exit /home/travis/build/neovim/neovim/build/../src/nvim/os_unix.c:102:3
=     #9 0x114608d in exit_event /home/travis/build/neovim/neovim/build/../src/nvim/msgpack_rpc/channel.c:557:5
=     #10 0xb02c8e in multiqueue_process_events /home/travis/build/neovim/neovim/build/../src/nvim/event/multiqueue.c:150:7
=     #11 0xafc087 in loop_poll_events /home/travis/build/neovim/neovim/build/../src/nvim/event/loop.c:66:3
=     #12 0x1360f73 in os_breakcheck /home/travis/build/neovim/neovim/build/../src/nvim/os/input.c:167:5
=     #13 0x10e5f49 in line_breakcheck /home/travis/build/neovim/neovim/build/../src/nvim/misc1.c:2747:5
=     #14 0x14ffb14 in nfa_regmatch /home/travis/build/neovim/neovim/build/../src/nvim/regexp_nfa.c:6316:5
=     #15 0x14e01bb in nfa_regtry /home/travis/build/neovim/neovim/build/../src/nvim/regexp_nfa.c:6390:16
=     #16 0x14ddef2 in nfa_regexec_both /home/travis/build/neovim/neovim/build/../src/nvim/regexp_nfa.c:6560:12
=     #17 0x148bf28 in nfa_regexec_nl /home/travis/build/neovim/neovim/build/../src/nvim/regexp_nfa.c:6706:10
=     #18 0x143f5a7 in vim_regexec_string /home/travis/build/neovim/neovim/build/../src/nvim/regexp.c:7250:16
=     #19 0x1440287 in vim_regexec_nl /home/travis/build/neovim/neovim/build/../src/nvim/regexp.c:7302:10
=     #20 0xa05c13 in find_some_match /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:12952:15
=     #21 0x96fb85 in f_matchstr /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:13230:3
=     #22 0x8a5160 in call_func /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6536:11
=     #23 0x8b7d67 in get_func_tv /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6277:11
=     #24 0x948a68 in eval7 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:4380:15
=     #25 0x94509a in eval6 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:4090:7
=     #26 0x942b65 in eval5 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3938:7
=     #27 0x93e35b in eval4 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3674:7
=     #28 0x93d7f3 in eval3 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3592:7
=     #29 0x93cca3 in eval2 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3523:7
=     #30 0x89e648 in eval1 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3450:7
=     #31 0x89ee16 in eval1 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3489:9
=     #32 0x89da72 in eval0 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3410:9
=     #33 0x8a93c0 in ex_let_const /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:1590:9
=     #34 0x8a9886 in ex_let /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:1531:3
=     #35 0xbfd379 in do_one_cmd /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:2247:5
=     #36 0xbdf488 in do_cmdline /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:593:20
=     #37 0x8d8056 in call_user_func /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:22775:3
=     #38 0x8a4a6d in call_func /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6521:11
=     #39 0x8b7d67 in get_func_tv /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6277:11
=     #40 0x948a68 in eval7 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:4380:15
=     #41 0x94509a in eval6 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:4090:7
=     #42 0x942b65 in eval5 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3938:7
=     #43 0x93e35b in eval4 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3674:7
=     #44 0x93d7f3 in eval3 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3592:7
=     #45 0x93cca3 in eval2 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3523:7
=     #46 0x89e648 in eval1 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3450:7
=     #47 0x89da72 in eval0 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3410:9
=     #48 0x8aa093 in eval_for_line /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:2662:7
=     #49 0xca28f5 in ex_while /home/travis/build/neovim/neovim/build/../src/nvim/ex_eval.c:967:14
=     #50 0xbfd379 in do_one_cmd /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:2247:5
=     #51 0xbdf488 in do_cmdline /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:593:20
=     #52 0x8d8056 in call_user_func /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:22775:3
=     #53 0x8a4a6d in call_func /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6521:11
=     #54 0x8b7d67 in get_func_tv /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6277:11
=     #55 0x948a68 in eval7 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:4380:15
=     #56 0x94509a in eval6 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:4090:7
=     #57 0x942b65 in eval5 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3938:7
=     #58 0x93e35b in eval4 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3674:7
=     #59 0x93d7f3 in eval3 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3592:7
=     #60 0x93cca3 in eval2 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3523:7
=     #61 0x89e648 in eval1 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3450:7
=     #62 0x89da72 in eval0 /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:3410:9
=     #63 0x8a93c0 in ex_let_const /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:1590:9
=     #64 0x8a9886 in ex_let /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:1531:3
=     #65 0xbfd379 in do_one_cmd /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:2247:5
=     #66 0xbdf488 in do_cmdline /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:593:20
=     #67 0x8d8056 in call_user_func /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:22775:3
=     #68 0x8a4a6d in call_func /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6521:11
=     #69 0x8b7d67 in get_func_tv /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:6277:11
=     #70 0x8b0c5e in ex_call /home/travis/build/neovim/neovim/build/../src/nvim/eval.c:2887:9
=     #71 0xbfd379 in do_one_cmd /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:2247:5
=     #72 0xbdf488 in do_cmdline /home/travis/build/neovim/neovim/build/../src/nvim/ex_docmd.c:593:20
=     #73 0xbc59a8 in do_source /home/travis/build/neovim/neovim/build/../src/nvim/ex_cmds2.c:3230:3
=     #74 0xbc05ae in source_callback /home/travis/build/neovim/neovim/build/../src/nvim/ex_cmds2.c:2365:9
=     #75 0xbbfe05 in do_in_path /home/travis/build/neovim/neovim/build/../src/nvim/ex_cmds2.c:2443:15
=     #76 0xbc026b in do_in_path_and_pp /home/travis/build/neovim/neovim/build/../src/nvim/ex_cmds2.c:2487:12
=     #77 0xbc0581 in source_in_path /home/travis/build/neovim/neovim/build/../src/nvim/ex_cmds2.c:2535:10
=     #78 0xf46b7e in load_plugins /home/travis/build/neovim/neovim/build/../src/nvim/main.c:1354:5
=     #79 0xf38926 in main /home/travis/build/neovim/neovim/build/../src/nvim/main.c:384:3
=     #80 0x7f0890bcd82f in __libc_start_main (/lib/x86_64-linux-gnu/libc.so.6+0x2082f)
=     #81 0x453db8 in _start (/home/travis/build/neovim/neovim/build/bin/nvim+0x453db8)
= 
= AddressSanitizer can not provide additional info.
= SUMMARY: AddressSanitizer: SEGV /tmp/final/llvm.src/projects/compiler-rt/lib/asan/../sanitizer_common/sanitizer_atomic_clang.h:81:10 in atomic_compare_exchange_strong<__sanitizer::atomic_uint8_t>
= ==16550==ABORTING
-=-=-=-=-=-

-=-=-=-=-=-
=====================================================================================================
test/helpers.lua:156: assertion failed!

stack traceback:
	test/helpers.lua:156: in function 'check_logs'
	test/functional/helpers.lua:864: in function <test/functional/helpers.lua:860>

[32m[2m[ RUN      ][0m[0m :Man man.lua: highlight_line() clears escape sequences from text and adds highlights: [2m18.42 ms[0m [1m[32mOK[0m[0m
[32m[2m[ RUN      ][0m[0m :Man man.lua: highlight_line() highlights multibyte text: [2m12.27 ms[0m [1m[32mOK[0m[0m
[32m[2m[ RUN      ][0m[0m :Man man.lua: highlight_line() highlights underscores based on context: [2m11.52 ms[0m [1m[32mOK[0m[0m
```

##### Keywords
→, , ←

#### 7    BuildFailureReason/C/vim@vim
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 7-=-=-=-=-=--=-=-=-=-=-
Input path: C/vim@vim/failed/557413766.log

	Test_term_gettitle(): can't get/set title
	test_windows_home.vim: not on MS-Windows

-------------------------------
Executed:  2193 Tests
 Skipped:    10 Tests
  FAILED:     1 Tests


Failures: 
-=-=-=-=-=-

-=-=-=-=-=-
	From test_quotestar.vim:
	Found errors in Test_quotestar():
	Run 1:
	function RunTheTest[40]..Test_quotestar[11]..Do_test_quotestar_for_x11 line 58: Expected 262044 but got 262040
	Run 2:
	Caught exception in Test_quotestar(): WaitFor() timed out after 5000 msec @ function RunTheTest[40]..Test_quotestar[11]..Do_test_quotestar_for_x11[56]..WaitFor, line 4
	Run 3:
	Caught exception in Test_quotestar(): WaitFor() timed out after 5000 msec @ function RunTheTest[40]..Test_quotestar[11]..Do_test_quotestar_for_x11[56]..WaitFor, line 4
	Flaky test failed too often, giving up
-=-=-=-=-=-

-=-=-=-=-=-

TEST FAILURE
make[2]: *** [report] Error 1
make[2]: Leaving directory `/home/travis/build/vim/vim/src/testdir'
make[1]: *** [scripttests] Error 2
make[1]: Leaving directory `/home/travis/build/vim/vim/src'
make: *** [scripttests] Error 2
travis_time:end:0dcc1920:start=1562861881455871857,finish=1562862066444826062,duration=184988954205
[0K[31;1mThe command "do_test make ${SHADOWOPT} ${TEST}" exited with 2.[0m
```

##### Keywords
→, , ←

#### 9    BuildFailureReason/Shell/tldr-pages@tldr
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 9-=-=-=-=-=--=-=-=-=-=-
Input path: Shell/tldr-pages@tldr/failed/566346797.log


travis_time:end:1dfc76ce:start=1564645431054196485,finish=1564645434697899079,duration=3643702594
[0Ktravis_fold:end:install.npm
[0K
travis_time:start:31881717
[0K$ npm test

> tldr@1.0.0 test /home/travis/build/tldr-pages/tldr
> bash -c 'markdownlint pages*/**/*.md && tldr-lint ./pages 2>&1 | tee test_result; test ${PIPESTATUS[0]} -eq 0'

-=-=-=-=-=-

-=-=-=-=-=-
Error: Parse error on line 35:
... encoding:`cmd /u`  `- Create file w
---------------------^
Expecting 'NEWLINE', 'TEXT', 'DASH', 'BACKTICK', got 'COMMAND_TEXT'
pages/windows/cmd.md:34: TLDR103 Command example is missing its closing backtick
-=-=-=-=-=-

-=-=-=-=-=-
[37;40mnpm[0m [0m[31;40mERR![0m[35m[0m Test failed.  See above for more details.
[0mtravis_time:end:31881717:start=1564645434703077646,finish=1564645436710614584,duration=2007536938
[0K[31;1mThe command "npm test" exited with 1.[0m

travis_time:start:1844cc1e
[0K$ bash scripts/build.sh
+initialize
+'[' -z '' ']'
+export TLDRHOME=/home/travis/build/tldr-pages/tldr
+TLDRHOME=/home/travis/build/tldr-pages/tldr
```

##### Keywords
→, , ←

#### 1    BuildFailureReason/C++/BVLC@caffe
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 1-=-=-=-=-=--=-=-=-=-=-
Input path: C++/BVLC@caffe/failed/214074807.log

-- Found OpenBLAS libraries: /usr/lib/libopenblas.so
-- Found OpenBLAS include: /usr/include
-- Found PythonInterp: /home/travis/venv/bin/python2.7 (found suitable version "2.7.6", minimum required is "2.7") 
-- Found PythonLibs: /usr/lib/x86_64-linux-gnu/libpython2.7.so (found suitable version "2.7.6", minimum required is "2.7") 
-- Found NumPy: /usr/lib/python2.7/dist-packages/numpy/core/include (found suitable version "1.8.2", minimum required is "1.7.1") 
-- NumPy ver. 1.8.2 found (include: /usr/lib/python2.7/dist-packages/numpy/core/include)
-- Boost version: 1.54.0
-- Found the following Boost libraries:
--   python
-- Could NOT find Doxygen (missing:  DOXYGEN_EXECUTABLE) 
-=-=-=-=-=-

-=-=-=-=-=-
CMake Error at /usr/share/cmake-3.2/Modules/FindPackageHandleStandardArgs.cmake:138 (message):
  Could NOT find Halide (missing: HALIDE_ROOT_DIR HALIDE_LIBRARIES
  HALIDE_INCLUDE_DIR)
Call Stack (most recent call first):
  /usr/share/cmake-3.2/Modules/FindPackageHandleStandardArgs.cmake:374 (_FPHSA_FAILURE_MESSAGE)
  cmake/Modules/FindHalide.cmake:38 (find_package_handle_standard_args)
  cmake/Dependencies.cmake:209 (find_package)
  CMakeLists.txt:46 (include)
-=-=-=-=-=-

-=-=-=-=-=-


-- Configuring incomplete, errors occurred!
See also "/home/travis/build/BVLC/caffe/build/CMakeFiles/CMakeOutput.log".
See also "/home/travis/build/BVLC/caffe/build/CMakeFiles/CMakeError.log".
```

##### Keywords
→, , ←

#### 2    BuildFailureReason/Elixir/elixir-lang@elixir
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Elixir/elixir-lang@elixir/failed/570288186.log


[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m

Finished in 71.4 seconds (40.8s on load, 30.6s on tests)
[32m1516 doctests, 3277 tests, 0 failures, 7 excluded[0m

Randomized with seed 695442
==> ex_unit (ex_unit)
[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m

-=-=-=-=-=-

-=-=-=-=-=-
  1) test assert received with multiple unique pinned variables (ExUnit.AssertionsTest)
     [1m[30mtest/ex_unit/assertions_test.exs:363[0m
     [31m** (MatchError) no match of right hand side value: {{:{}, [line: 369], [:status, {:^, [line: 369], [{:status, [line: 369], nil}]}, {:^, [line: 369], [{:other_status, [line: 369], nil}]}]}, [{:status, :invalid, :invalid}]}[0m
     [36mcode: [0m[{:status, :invalid, :invalid}] = error.mailbox
     [36mstacktrace:[0m
       test/ex_unit/assertions_test.exs:380: (test)
-=-=-=-=-=-

-=-=-=-=-=-

[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m

  2) test assert received when different message (ExUnit.AssertionsTest)
     [1m[30mtest/ex_unit/assertions_test.exs:396[0m
     [31m** (MatchError) no match of right hand side value: {:hello, [{:message, :not_expected, :at_all}]}[0m
     [36mcode: [0m[{:message, :not_expected, :at_all}] = error.mailbox
     [36mstacktrace:[0m
       test/ex_unit/assertions_test.exs:408: (test)
```

##### Keywords
→, , ←

#### 2    BuildFailureReason/Python/vinta@awesome-python
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 2-=-=-=-=-=--=-=-=-=-=-
Input path: Python/vinta@awesome-python/failed/125333673.log

  695. https://github.com/vinta/awesome-python/blob/master/CONTRIBUTING.md
  696. https://github.com/vinta/awesome-python/pulls
Checking URLs: ✓✓✓✓✓✓✓✓✓✓✓✓✓✓→✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓→✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓✓?
Checking white listed URLs: →?

> White listed:
  1. 302 http://pyparsing.wikispaces.com/ → https://session.wikispaces.com/1/auth/auth?authToken=05cac738fa082d0a230cce4e3bb839fc3
  2. http://www.graphviz.org/ Connection timed out - connect(2) for "www.graphviz.org" port 80

Issues :-(
-=-=-=-=-=-

-=-=-=-=-=-
> Links 
  1. 301 https://warehouse.python.org/ → https://pypi.io/
  2. 301 http://www.joke2k.net/faker/ → http://joke2k.net/faker/
  3. http://www.clips.ua.ac.be/pattern Net::ReadTimeout
-=-=-=-=-=-

-=-=-=-=-=-

travis_time:end:26893f02:start=1461480066286951159,finish=1461480320242157966,duration=253955206807
[0K
[31;1mThe command "awesome_bot README.md --allow-dupe --white-list pyparsing,graphviz.org" exited with 1.[0m

Done. Your build exited with 1.
```

##### Keywords
→, , ←

#### 8    BuildFailureReason/R/twitter@AnomalyDetection
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 8-=-=-=-=-=--=-=-=-=-=-
Input path: R/twitter@AnomalyDetection/failed/74461732.log

* checking for unstated dependencies in examples ... OK
* checking contents of ‘data’ directory ... OK
* checking data for non-ASCII characters ... OK
* checking data for ASCII and uncompressed saves ... OK
* checking examples ... OK
Examples with CPU or elapsed time > 5s
                    user system elapsed
AnomalyDetectionTs 5.133  0.041   5.174
* checking for unstated dependencies in ‘tests’ ... OK
* checking tests ...
-=-=-=-=-=-

-=-=-=-=-=-
  Running ‘testthat.R’ [19s/19s]
 ERROR
Running the tests in ‘tests/testthat.R’ failed.
Last 13 lines of output:
  
  > library('testthat')
  > test_check("AnomalyDetection") 
  Loading required package: AnomalyDetection
  1. Failure (at test-ts.R#29): average the count for each unique timestamp if the timestamps are not unique 
  AnomalyDetectionTs(raw_data, max_anoms = 0.02, direction = "both", plot = TRUE, unique_by_time = TRUE) threw an error
  
  testthat results ================================================================
  OK: 30 SKIPPED: 0 FAILED: 1
  1. Failure (at test-ts.R#29): average the count for each unique timestamp if the timestamps are not unique 
  
  Error: testthat unit tests failed
-=-=-=-=-=-

-=-=-=-=-=-
  Execution halted
* DONE

Status: 1 ERROR, 2 WARNINGs, 2 NOTEs
See
  ‘/home/travis/build/twitter/AnomalyDetection/AnomalyDetection.Rcheck/00check.log’
for details.

travis_time:end:13d1edc8:start=1438888850359469323,finish=1438888892985538738,duration=42626069415
[0K
```

##### Keywords
→, , ←

#### 3    BuildFailureReason/Lua/martanne@vis
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Lua/martanne@vis/failed/243935654.log

[32;1mThe command "if [ -e vis ]; then LD_LIBRARY_PATH="$(pwd)/dependency/install/usr/lib" ./vis -v; file vis; size vis; if [ "$TRAVIS_OS_NAME" = "osx" ]; then otool -L vis; else ldd vis; fi fi" exited with 0.[0m
travis_time:start:12b50989
[0K$ make -C test/core coverage
make: Entering directory `/home/travis/build/martanne/vis/test/core'
cleaning
make CFLAGS_EXTRA='--coverage'
make[1]: Entering directory `/home/travis/build/martanne/vis/test/core'
Generating ccan configuration header
Compiling buffer-test binary
Compiling map-test binary
-=-=-=-=-=-

-=-=-=-=-=-
/tmp/ccHp5IXX.o: In function `build_values':
map.c:(.text.build_values+0xd): undefined reference to `array_add_ptr'
-=-=-=-=-=-

-=-=-=-=-=-
collect2: ld returned 1 exit status
make[1]: *** [map-test] Error 1
make[1]: Leaving directory `/home/travis/build/martanne/vis/test/core'
make: *** [coverage] Error 2
make: Leaving directory `/home/travis/build/martanne/vis/test/core'

travis_time:end:12b50989:start=1497688976336733483,finish=1497688982191481985,duration=5854748502
[0K
[31;1mThe command "make -C test/core coverage" exited with 2.[0m
travis_time:start:26f593ac
```

##### Keywords
→, , ←

#### 3    BuildFailureReason/Scala/akka@akka
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Scala/akka@akka/failed/562556292.log

[0m[[0m[0minfo[0m] [0m[0mDone compiling.[0m
[0m[[0m[0minfo[0m] [0m[0mCompiling 45 Java sources to /home/travis/build/akka/akka/akka-protobuf/target/classes ...[0m
[0m[[0m[0minfo[0m] [0m[0mDone compiling.[0m
[0m[[0m[0minfo[0m] [0m[0mCompiling 5 Scala sources to /home/travis/build/akka/akka/akka-discovery/target/classes ...[0m
[0m[[0m[0minfo[0m] [0m[0mDone compiling.[0m
[0m[[0m[0minfo[0m] [0m[0mCompiling 32 Scala sources to /home/travis/build/akka/akka/akka-actor-testkit-typed/target/classes ...[0m
[0m[[0m[0minfo[0m] [0m[0mDone compiling.[0m
[0m[[0m[0minfo[0m] [0m[0mCompiling 39 Scala sources and 6 Java sources to /home/travis/build/akka/akka/akka-persistence/target/classes ...[0m
[0m[[0m[0minfo[0m] [0m[0mDone compiling.[0m
[0m[[0m[0minfo[0m] [0m[0mCompiling 172 Scala sources and 3 Java sources to /home/travis/build/akka/akka/akka-stream/target/classes ...[0m
-=-=-=-=-=-

-=-=-=-=-=-
[0m[[0m[31merror[0m] [0m[0m/home/travis/build/akka/akka/akka-stream/src/main/scala/akka/stream/impl/ReactiveStreamsCompliance.scala:133:47: The unicode arrow `⇒` is deprecated, use `=>` instead. If you still wish to display it as one character, consider using a font with programming ligatures such as Fira Code.[0m
[0m[[0m[31merror[0m] [0m[0m      case s: SubscriptionWithCancelException ⇒ s.cancel(cause)[0m
[0m[[0m[31merror[0m] [0m[0m                                              ^[0m
[0m[[0m[31merror[0m] [0m[0m/home/travis/build/akka/akka/akka-stream/src/main/scala/akka/stream/impl/ReactiveStreamsCompliance.scala:134:14: The unicode arrow `⇒` is deprecated, use `=>` instead. If you still wish to display it as one character, consider using a font with programming ligatures such as Fira Code.[0m
[0m[[0m[31merror[0m] [0m[0m      case s ⇒ s.cancel()[0m
[0m[[0m[31merror[0m] [0m[0m             ^[0m
[0m[[0m[31merror[0m] [0m[0m/home/travis/build/akka/akka/akka-stream/src/main/scala/akka/stream/impl/ReactiveStreamsCompliance.scala:136:24: The unicode arrow `⇒` is deprecated, use `=>` instead. If you still wish to display it as one character, consider using a font with programming ligatures such as Fira Code.[0m
[0m[[0m[31merror[0m] [0m[0m      case NonFatal(t) ⇒ throw new SignalThrewException("It is illegal to throw exceptions from cancel(), rule 3.15", t)[0m
[0m[[0m[31merror[0m] [0m[0m                       ^[0m
[0m[[0m[31merror[0m] [0m[0m/home/travis/build/akka/akka/akka-stream/src/main/scala/akka/stream/impl/StreamLayout.scala:179:24: The unicode arrow `⇒` is deprecated, use `=>` instead. If you still wish to display it as one character, consider using a font with programming ligatures such as Fira Code.[0m
[0m[[0m[31merror[0m] [0m[0m        case state @ _ ⇒[0m
[0m[[0m[31merror[0m] [0m[0m                       ^[0m
[0m[[0m[31merror[0m] [0m[0mfour errors found[0m
-=-=-=-=-=-

-=-=-=-=-=-
[0m[[0m[0minfo[0m] [0m[0mCompiling 31 Scala sources to /home/travis/build/akka/akka/akka-persistence-typed/target/classes ...[0m
[0m[[0m[0minfo[0m] [0m[0mDone compiling.[0m
[0m[[0m[0minfo[0m] [0m[0mCompiling 9 Scala sources to /home/travis/build/akka/akka/akka-coordination/target/classes ...[0m
[0m[[0m[0minfo[0m] [0m[0mDone compiling.[0m
[0m[[0m[31merror[0m] [0m[0m(akka-stream / Compile / [31mcompileIncremental[0m) Compilation failed[0m
[0m[[0m[31merror[0m] [0m[0mTotal time: 119 s, completed Jul 23, 2019 12:06:28 PM[0m
travis_time:end:011163aa:start=1563883377570692767,finish=1563883588536082745,duration=210965389978
[0K[31;1mThe command "sbt -jvm-opts .jvmopts-travis -Dakka.build.scalaVersion=$TRAVIS_SCALA_VERSION ";update ;mimaReportBinaryIssues ;test:compile ;validateCompile"" exited with 1.[0m

travis_fold:start:before_cache.1
```

##### Keywords
→, , ←

#### 8    BuildFailureReason/TypeScript/Microsoft@TypeScript
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 8-=-=-=-=-=--=-=-=-=-=-
Input path: TypeScript/Microsoft@TypeScript/failed/567134594.log

[?25h[?25l[80D[1A[0K  [90m[[0m[31m▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬[0m[90m․․․[0m[90m][0m[31m 3 failing[0m
[?25h[?25l[80D[1A[0K  [90m[[0m[31m▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬[0m[90m․․[0m[90m][0m[31m 3 failing[0m
[?25h[?25l[80D[1A[0K  [90m[[0m[31m▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬[0m[90m․[0m[90m][0m[31m 3 failing[0m
[?25h[?25l[80D[1A[0K  [90m[[0m[31m▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬[0m[90m[0m[90m][0m[31m 3 failing[0m
[?25h[?25l[80D[1A[0K  [90m[[0m[31m▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬[0m[90m[0m[90m][0m[90m [31m✖ 65874/65877 passing[0m [90m(11m)[0m[0m
[?25h

  65874 passing (11m)
  3 failing

-=-=-=-=-=-

-=-=-=-=-=-
  1) 
       
         conformance tests
           conformance tests for tests/cases/conformance/types/conditional/inferTypes1.ts
             Correct type/symbol baselines for tests/cases/conformance/types/conditional/inferTypes1.ts:
     Error: The baseline file inferTypes1.types has changed.
      at writeComparison (src/harness/harness.ts:1724:23)
      at Object.runBaseline (src/harness/harness.ts:1734:13)
      at checkBaseLines (src/harness/harness.ts:1189:30)
      at Object.doTypeAndSymbolBaseline (src/harness/harness.ts:1152:17)
      at CompilerTest.verifyTypesAndSymbols (src/testRunner/compilerRunner.ts:259:26)
      at Context.<anonymous> (src/testRunner/compilerRunner.ts:90:82)
      at processImmediate (internal/timers.js:439:21)

  2) 
       
         conformance tests
           conformance tests for tests/cases/conformance/types/conditional/inferTypes2.ts
             Correct errors for tests/cases/conformance/types/conditional/inferTypes2.ts:
     Error: The baseline file inferTypes2.errors.txt has changed.
      at writeComparison (src/harness/harness.ts:1724:23)
      at Object.runBaseline (src/harness/harness.ts:1734:13)
      at Object.doErrorBaseline (src/harness/harness.ts:1125:22)
      at CompilerTest.verifyDiagnostics (src/testRunner/compilerRunner.ts:207:26)
      at Context.<anonymous> (src/testRunner/compilerRunner.ts:85:67)
      at processImmediate (internal/timers.js:439:21)

  3) 
       
         conformance tests
           conformance tests for tests/cases/conformance/types/conditional/inferTypes2.ts
             Correct type/symbol baselines for tests/cases/conformance/types/conditional/inferTypes2.ts:
     Error: The baseline file inferTypes2.types has changed.
      at writeComparison (src/harness/harness.ts:1724:23)
      at Object.runBaseline (src/harness/harness.ts:1734:13)
      at checkBaseLines (src/harness/harness.ts:1189:30)
      at Object.doTypeAndSymbolBaseline (src/harness/harness.ts:1152:17)
      at CompilerTest.verifyTypesAndSymbols (src/testRunner/compilerRunner.ts:259:26)
      at Context.<anonymous> (src/testRunner/compilerRunner.ts:90:82)
      at processImmediate (internal/timers.js:439:21)
-=-=-=-=-=-

-=-=-=-=-=-



[[90m21:48:04[39m] '[36mrunTestsParallel[39m' [31merrored after[39m [35m11 min[39m
[[90m21:48:04[39m] Error: Process exited with code: 3
    at ChildProcess.<anonymous> (/home/travis/build/microsoft/TypeScript/scripts/build/utils.js:52:24)
    at ChildProcess.emit (events.js:203:13)
    at ChildProcess.EventEmitter.emit (domain.js:494:23)
    at Process.ChildProcess._handle.onexit (internal/child_process.js:272:12)
[[90m21:48:04[39m] '[36mruntests-parallel[39m' [31merrored after[39m [35m11 min[39m
```

##### Keywords
→, , ←

#### 6    BuildFailureReason/Haskell/jgm@pandoc
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 6-=-=-=-=-=--=-=-=-=-=-
Input path: Haskell/jgm@pandoc/failed/480353000.log

      writer
        basic:                                                       OK (0.15s)
        tables:                                                      OK (0.03s)
    creole
      reader:                                                        OK (0.08s)
    custom writer
      basic:                                                         OK (0.19s)
      tables:                                                        FAIL (0.06s)
        
        ------------------------------------------------------------------------
-=-=-=-=-=-

-=-=-=-=-=-
        --- tables.custom
        +++ /home/travis/build/jgm/pandoc/sourcedist/dist/build/pandoc/pandoc --quiet tables.native -f native -t ../data/sample.lua
        +  29 </table>
        -  29 </table
        +  58 </table>
        -  58 </table
        +  88 </table>
        -  88 </table
        + 122 </table>
        - 122 </table
        + 154 </table>
        - 154 </table
        + 177 </table>
        - 177 </table
        + 200 </table>
        - 200 </table
-=-=-=-=-=-

-=-=-=-=-=-
        ------------------------------------------------------------------------
    man
      reader:                                                        OK (0.04s)
  Shared
    compactifyDL
      compactifyDL with empty def:                                   OK
    collapseFilePath
      collapse:                                                      OK
      collapse:                                                      OK
      collapse:                                                      OK
```

##### Keywords
→, , ←

#### 9    BuildFailureReason/Java/square@retrofit
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 9-=-=-=-=-=--=-=-=-=-=-
Input path: Java/square@retrofit/failed/494086613.log

INFO: MockWebServer[36771] starting to accept connections
Feb 16, 2019 2:44:52 AM okhttp3.mockwebserver.MockWebServer$2 acceptConnections
INFO: MockWebServer[36771] done accepting connections: Socket closed
Tests run: 3, Failures: 0, Errors: 0, Skipped: 0, Time elapsed: 14.809 sec
Running retrofit2.KotlinSuspendRawTest
Feb 16, 2019 2:44:52 AM okhttp3.mockwebserver.MockWebServer$2 execute
INFO: MockWebServer[33866] starting to accept connections
Feb 16, 2019 2:44:52 AM okhttp3.mockwebserver.MockWebServer$2 acceptConnections
INFO: MockWebServer[33866] done accepting connections: Socket closed
Tests run: 1, Failures: 0, Errors: 1, Skipped: 0, Time elapsed: 0.061 sec <<< FAILURE!
-=-=-=-=-=-

-=-=-=-=-=-
raw(retrofit2.KotlinSuspendRawTest)  Time elapsed: 0.053 sec  <<< ERROR!
java.lang.NullPointerException
	at retrofit2.Utils.isKotlinMethodReturnTypeNullable(Utils.java:541)
	at retrofit2.HttpServiceMethod.parseAnnotations(HttpServiceMethod.java:52)
	at retrofit2.ServiceMethod.parseAnnotations(ServiceMethod.java:37)
	at retrofit2.Retrofit.loadServiceMethod(Retrofit.java:169)
	at retrofit2.Retrofit$1.invoke(Retrofit.java:148)
	at retrofit2.$Proxy40.body(Unknown Source)
	at retrofit2.KotlinSuspendRawTest.raw(KotlinSuspendRawTest.java:46)
	at sun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)
	at sun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:62)
	at sun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:43)
	at java.lang.reflect.Method.invoke(Method.java:498)
	at org.junit.runners.model.FrameworkMethod$1.runReflectiveCall(FrameworkMethod.java:50)
	at org.junit.internal.runners.model.ReflectiveCallable.run(ReflectiveCallable.java:12)
	at org.junit.runners.model.FrameworkMethod.invokeExplosively(FrameworkMethod.java:47)
	at org.junit.internal.runners.statements.InvokeMethod.evaluate(InvokeMethod.java:17)
	at org.junit.rules.ExternalResource$1.evaluate(ExternalResource.java:48)
	at org.junit.rules.RunRules.evaluate(RunRules.java:20)
	at org.junit.runners.ParentRunner.runLeaf(ParentRunner.java:325)
	at org.junit.runners.BlockJUnit4ClassRunner.runChild(BlockJUnit4ClassRunner.java:78)
	at org.junit.runners.BlockJUnit4ClassRunner.runChild(BlockJUnit4ClassRunner.java:57)
	at org.junit.runners.ParentRunner$3.run(ParentRunner.java:290)
	at org.junit.runners.ParentRunner$1.schedule(ParentRunner.java:71)
	at org.junit.runners.ParentRunner.runChildren(ParentRunner.java:288)
	at org.junit.runners.ParentRunner.access$000(ParentRunner.java:58)
	at org.junit.runners.ParentRunner$2.evaluate(ParentRunner.java:268)
	at org.junit.runners.ParentRunner.run(ParentRunner.java:363)
	at org.apache.maven.surefire.junit4.JUnit4Provider.execute(JUnit4Provider.java:252)
	at org.apache.maven.surefire.junit4.JUnit4Provider.executeTestSet(JUnit4Provider.java:141)
	at org.apache.maven.surefire.junit4.JUnit4Provider.invoke(JUnit4Provider.java:112)
	at sun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)
	at sun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:62)
	at sun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:43)
	at java.lang.reflect.Method.invoke(Method.java:498)
	at org.apache.maven.surefire.util.ReflectionUtils.invokeMethodWithArray(ReflectionUtils.java:189)
	at org.apache.maven.surefire.booter.ProviderFactory$ProviderProxy.invoke(ProviderFactory.java:165)
	at org.apache.maven.surefire.booter.ProviderFactory.invokeProvider(ProviderFactory.java:85)
	at org.apache.maven.surefire.booter.ForkedBooter.runSuitesInProcess(ForkedBooter.java:115)
	at org.apache.maven.surefire.booter.ForkedBooter.main(ForkedBooter.java:75)
-=-=-=-=-=-

-=-=-=-=-=-

Running retrofit2.CompletableFutureAndroidTest
Feb 16, 2019 2:44:52 AM okhttp3.mockwebserver.MockWebServer$2 execute
INFO: MockWebServer[48310] starting to accept connections
Feb 16, 2019 2:44:52 AM okhttp3.mockwebserver.MockWebServer$2 acceptConnections
INFO: MockWebServer[48310] done accepting connections: Socket closed
Feb 16, 2019 2:44:52 AM okhttp3.mockwebserver.MockWebServer$2 execute
INFO: MockWebServer[36448] starting to accept connections
Feb 16, 2019 2:44:52 AM okhttp3.mockwebserver.MockWebServer$3 processOneRequest
INFO: MockWebServer[36448] received request: GET / HTTP/1.1 and responded: HTTP/1.1 200 OK
```

##### Keywords
→, , ←

#### 10   BuildFailureReason/Shell/jwilder@nginx-proxy
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 10-=-=-=-=-=--=-=-=-=-=-
Input path: Shell/jwilder@nginx-proxy/failed/565363656.log

test_ssl/test_wildcard.py::test_web1_HSTS_policy_is_active[foo] [31mFAILED[0m
test_ssl/test_wildcard.py::test_web1_HSTS_policy_is_active[bar] [31mFAILED[0m
test_ssl/wildcard_cert_and_nohttps/test_wildcard_cert_nohttps.py::test_http_redirects_to_https[1-True] [31mFAILED[0m
test_ssl/wildcard_cert_and_nohttps/test_wildcard_cert_nohttps.py::test_http_redirects_to_https[2-True] [31mFAILED[0m
test_ssl/wildcard_cert_and_nohttps/test_wildcard_cert_nohttps.py::test_http_redirects_to_https[3-False] [31mFAILED[0m
test_ssl/wildcard_cert_and_nohttps/test_wildcard_cert_nohttps.py::test_https_get_served[1] [31mFAILED[0m
test_ssl/wildcard_cert_and_nohttps/test_wildcard_cert_nohttps.py::test_https_get_served[2] [31mFAILED[0m
test_ssl/wildcard_cert_and_nohttps/test_wildcard_cert_nohttps.py::test_web3_https_is_500_and_SSL_validation_fails [31mFAILED[0m

=================================== FAILURES ===================================
-=-=-=-=-=-

-=-=-=-=-=-
[1m[31m__________________________ test_unknown_virtual_host ___________________________[0m

docker_compose = <docker.client.DockerClient object at 0x7f9a970d3ad0>
nginxproxy = <conftest.requests_for_docker object at 0x7f9a96f34f10>

[1m    def test_unknown_virtual_host(docker_compose, nginxproxy):[0m
[1m>       r = nginxproxy.get("http://nginx-proxy/port")[0m

[1m[31mtest_DOCKER_HOST_unix_socket.py[0m:4: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31mconftest.py[0m:83: in get
[1m    return _get(*args, **kwargs)[0m
[1m[31m/usr/local/lib/python2.7/site-packages/backoff.py[0m:173: in retry
[1m    ret = target(*args, **kwargs)[0m
[1m[31mconftest.py[0m:82: in _get
[1m    return self.session.get(*args, **kwargs)[0m
[1m[31m/usr/local/lib/python2.7/site-packages/requests/sessions.py[0m:488: in get
[1m    return self.request('GET', url, **kwargs)[0m
[1m[31m/usr/local/lib/python2.7/site-packages/requests/sessions.py[0m:475: in request
[1m    resp = self.send(prep, **send_kwargs)[0m
[1m[31m/usr/local/lib/python2.7/site-packages/requests/sessions.py[0m:596: in send
[1m    r = adapter.send(request, **kwargs)[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <requests.adapters.HTTPAdapter object at 0x7f9a96f66390>
request = <PreparedRequest [GET]>, stream = False
timeout = <requests.packages.urllib3.util.timeout.Timeout object at 0x7f9a96f66b50>
verify = '/home/travis/build/jwilder/nginx-proxy/test/certs/ca-root.crt'
cert = None, proxies = OrderedDict()

[1m    def send(self, request, stream=False, timeout=None, verify=True, cert=None, proxies=None):[0m
[1m        """Sends PreparedRequest object. Returns Response object.[0m
[1m    [0m
[1m            :param request: The :class:`PreparedRequest <PreparedRequest>` being sent.[0m
[1m            :param stream: (optional) Whether to stream the request content.[0m
[1m            :param timeout: (optional) How long to wait for the server to send[0m
[1m                data before giving up, as a float, or a :ref:`(connect timeout,[0m
[1m                read timeout) <timeouts>` tuple.[0m
[1m            :type timeout: float or tuple[0m
[1m            :param verify: (optional) Whether to verify SSL certificates.[0m
[1m            :param cert: (optional) Any user-provided SSL certificate to be trusted.[0m
[1m            :param proxies: (optional) The proxies dictionary to apply to the request.[0m
[1m            :rtype: requests.Response[0m
[1m            """[0m
[1m    [0m
[1m        conn = self.get_connection(request.url, proxies)[0m
[1m    [0m
[1m        self.cert_verify(conn, request.url, verify, cert)[0m
[1m        url = self.request_url(request, proxies)[0m
[1m        self.add_headers(request)[0m
[1m    [0m
[1m        chunked = not (request.body is None or 'Content-Length' in request.headers)[0m
[1m    [0m
[1m        if isinstance(timeout, tuple):[0m
[1m            try:[0m
[1m                connect, read = timeout[0m
[1m                timeout = TimeoutSauce(connect=connect, read=read)[0m
[1m            except ValueError as e:[0m
[1m                # this may raise a string formatting error.[0m
[1m                err = ("Invalid timeout {0}. Pass a (connect, read) "[0m
[1m                       "timeout tuple, or a single float to set "[0m
[1m                       "both timeouts to the same value".format(timeout))[0m
[1m                raise ValueError(err)[0m
[1m        else:[0m
[1m            timeout = TimeoutSauce(connect=timeout, read=timeout)[0m
[1m    [0m
[1m        try:[0m
[1m            if not chunked:[0m
[1m                resp = conn.urlopen([0m
[1m                    method=request.method,[0m
[1m                    url=url,[0m
[1m                    body=request.body,[0m
[1m                    headers=request.headers,[0m
[1m                    redirect=False,[0m
[1m                    assert_same_host=False,[0m
[1m                    preload_content=False,[0m
[1m                    decode_content=False,[0m
[1m                    retries=self.max_retries,[0m
[1m                    timeout=timeout[0m
[1m                )[0m
[1m    [0m
[1m            # Send the request.[0m
[1m            else:[0m
[1m                if hasattr(conn, 'proxy_pool'):[0m
[1m                    conn = conn.proxy_pool[0m
[1m    [0m
[1m                low_conn = conn._get_conn(timeout=DEFAULT_POOL_TIMEOUT)[0m
[1m    [0m
[1m                try:[0m
[1m                    low_conn.putrequest(request.method,[0m
[1m                                        url,[0m
[1m                                        skip_accept_encoding=True)[0m
[1m    [0m
[1m                    for header, value in request.headers.items():[0m
[1m                        low_conn.putheader(header, value)[0m
[1m    [0m
[1m                    low_conn.endheaders()[0m
[1m    [0m
[1m                    for i in request.body:[0m
[1m                        low_conn.send(hex(len(i))[2:].encode('utf-8'))[0m
[1m                        low_conn.send(b'\r\n')[0m
[1m                        low_conn.send(i)[0m
[1m                        low_conn.send(b'\r\n')[0m
[1m                    low_conn.send(b'0\r\n\r\n')[0m
[1m    [0m
[1m                    # Receive the response from the server[0m
[1m                    try:[0m
[1m                        # For Python 2.7+ versions, use buffering of HTTP[0m
[1m                        # responses[0m
[1m                        r = low_conn.getresponse(buffering=True)[0m
[1m                    except TypeError:[0m
[1m                        # For compatibility with Python 2.6 versions and back[0m
[1m                        r = low_conn.getresponse()[0m
[1m    [0m
[1m                    resp = HTTPResponse.from_httplib([0m
[1m                        r,[0m
[1m                        pool=conn,[0m
[1m                        connection=low_conn,[0m
[1m                        preload_content=False,[0m
[1m                        decode_content=False[0m
[1m                    )[0m
[1m                except:[0m
[1m                    # If we hit any problems here, clean up the connection.[0m
[1m                    # Then, reraise so that we can handle the actual exception.[0m
[1m                    low_conn.close()[0m
[1m                    raise[0m
[1m    [0m
[1m        except (ProtocolError, socket.error) as err:[0m
[1m            raise ConnectionError(err, request=request)[0m
[1m    [0m
[1m        except MaxRetryError as e:[0m
[1m            if isinstance(e.reason, ConnectTimeoutError):[0m
[1m                # TODO: Remove this in 3.0.0: see #2811[0m
[1m                if not isinstance(e.reason, NewConnectionError):[0m
[1m                    raise ConnectTimeout(e, request=request)[0m
[1m    [0m
[1m            if isinstance(e.reason, ResponseError):[0m
[1m                raise RetryError(e, request=request)[0m
[1m    [0m
[1m            if isinstance(e.reason, _ProxyError):[0m
[1m                raise ProxyError(e, request=request)[0m
[1m    [0m
[1m>           raise ConnectionError(e, request=request)[0m
[1m[31mE           ConnectionError: HTTPConnectionPool(host='nginx-proxy', port=80): Max retries exceeded with url: /port (Caused by NewConnectionError('<requests.packages.urllib3.connection.HTTPConnection object at 0x7f9a96f4b610>: Failed to establish a new connection: [Errno -2] Name does not resolve',))[0m

[1m[31m/usr/local/lib/python2.7/site-packages/requests/adapters.py[0m:487: ConnectionError
-=-=-=-=-=-

-=-=-=-=-=-
------------------------------- nginx-proxy logs -------------------------------
Custom dhparam.pem file found, generation skipped
[0;37;1mforego       | [0mstarting htpasswdgen.1 on port 5000
[0;37;1mforego       | [0mstarting dockergen.1 on port 5100
[0;37;1mforego       | [0mstarting nginx.1 on port 5300
[0;36;1mhtpasswdgen.1 | [0;31;1m2019/07/30 08:04:21 Generated '/app/htpasswd_generator.sh' from 4 containers
[0m[0;36;1mhtpasswdgen.1 | [0;31;1m2019/07/30 08:04:21 Running '/app/htpasswd_generator.sh'
[0m[0;33;1mdockergen.1  | [0;31;1m2019/07/30 08:04:21 Unable to parse template: template: nginx.tmpl:130: undefined variable "$container"
[0m[0;37;1mforego       | [0mstarting dockergen.1 on port 5400
[0;37;1mforego       | [0msending SIGTERM to nginx.1
```

##### Keywords
→, , ←

#### 3    BuildFailureReason/Ruby/jekyll@jekyll
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Ruby/jekyll@jekyll/failed/558541567.log

# SEE: https://github.com/jekyll/jekyll/issues/4719
# -------------------------------------------------------------

# Running tests with run options --profile --seed 1041:

[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[31mF[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m[32m.[0m

[31mFinished tests in 66.101667s, 13.1313 tests/s, 23.5244 assertions/s.[0m


-=-=-=-=-=-

-=-=-=-=-=-
[31mFailure:
TestKramdown#test_: kramdown when a custom highlighter is chosen should use the chosen highlighter if it's available.  [/home/travis/build/jekyll/jekyll/test/test_kramdown.rb:106]
Minitest::Assertion: Expected true to not be truthy.[0m
-=-=-=-=-=-

-=-=-=-=-=-

[31m868 tests, 1555 assertions, 1 failures, 0 errors, 0 skips[0m

================================================================================
Your 10 Slowest Tests
================================================================================

 3.6659ms - TestSite#test_: creating sites should write static files if not modified but missing in destination. 
 3.4958ms - TestSite#test_: creating sites should write only modified static files. 
 3.3675ms - TestSite#test_: creating sites incremental build should build incrementally. 
```

##### Keywords
→, , ←

#### 7    BuildFailureReason/Go/avelino@awesome-go
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 7-=-=-=-=-=--=-=-=-=-=-
Input path: Go/avelino@awesome-go/failed/560330322.log

    --- PASS: TestAlpha/Libraries_for_handling_errors. (0.00s)
    --- PASS: TestAlpha/Libraries_for_handling_files_and_file_systems. (0.00s)
    --- PASS: TestAlpha/Packages_for_accounting_and_finance. (0.00s)
    --- PASS: TestAlpha/Libraries_for_working_with_forms. (0.00s)
    --- PASS: TestAlpha/Packages_to_support_functional_programming_in_Go. (0.00s)
    --- PASS: TestAlpha/Awesome_game_development_libraries. (0.00s)
    --- PASS: TestAlpha/Tools_to_enhance_the_language_with_features_like_generics_via_code_generation. (0.00s)
    --- PASS: TestAlpha/Geographic_tools_and_servers (0.00s)
    --- PASS: TestAlpha/Tools_for_compiling_Go_to_other_languages. (0.00s)
    --- PASS: TestAlpha/Tools_for_managing_and_working_with_Goroutines. (0.00s)
-=-=-=-=-=-

-=-=-=-=-=-
    --- FAIL: TestAlpha/Libraries_for_developing_GraphQL_servers_in_Go. (0.00s)
        repo_test.go:131: expected 'gqlgen' but actual is 'graphql-go'
        repo_test.go:131: expected 'graphql-go' but actual is 'gqlgen'
        repo_test.go:135: expected order is:
            appointy/jaal
            gqlgen
            graph-gophers/graphql-go
            graphql-go
            graphql-relay-go
            machinebox/graphql
            samsarahq/thunder
-=-=-=-=-=-

-=-=-=-=-=-
    --- PASS: TestAlpha/Toolkits (0.00s)
    --- PASS: TestAlpha/Interaction (0.00s)
    --- PASS: TestAlpha/Libraries_for_manipulating_images. (0.00s)
    --- PASS: TestAlpha/Libraries_for_programming_devices_of_the_IoT. (0.00s)
    --- PASS: TestAlpha/Libraries_for_scheduling_jobs. (0.00s)
    --- PASS: TestAlpha/Libraries_for_working_with_JSON. (0.00s)
    --- PASS: TestAlpha/Libraries_for_generating_and_working_with_log_files. (0.00s)
    --- PASS: TestAlpha/Libraries_for_Machine_Learning. (0.00s)
    --- PASS: TestAlpha/Libraries_that_implement_messaging_systems. (0.00s)
    --- PASS: TestAlpha/Microsoft_Office#01 (0.00s)
```

##### Keywords
→, , ←



## Categories
For each mentioned repository/buildlog here, look all the extraction & context I posted here. Categorize them according to their structure, if two BuildFailureReasons look like they have occured at the "same step" within the build / "same position" within the log they go into the same category. For each extraction & context write the category between the arrows: →←. Start from the top with 0 and count up whole numbers.

#### BuildFailureReason/Python/nvbn@thefuck
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 1-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/530361507.log

tests/specific/test_npm.py::test_get_scripts [32mPASSED[0m[36m                      [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-sudo ls-ls-sudo ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-ls-ls-ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[return_value2-sudo ls-ls-result2] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-sudo ls-ls-True] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-ls-ls-True] [32mPASSED[0m[36m   [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-sudo ls-ls-False] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-ls-ls-False] [32mPASSED[0m[36m [100%][0m

=================================== FAILURES ===================================
-=-=-=-=-=-

-=-=-=-=-=-
[31m[1m_________________________________ test_readme __________________________________[0m

source_root = PosixPath('/home/travis/build/nvbn/thefuck')

[1m    def test_readme(source_root):[0m
[1m        with source_root.joinpath('README.md').open() as f:[0m
[1m            readme = f.read()[0m
[1m    [0m
[1m            bundled = source_root.joinpath('thefuck') \[0m
[1m                                 .joinpath('rules') \[0m
[1m                                 .glob('*.py')[0m
[1m    [0m
[1m            for rule in bundled:[0m
[1m                if rule.stem != '__init__':[0m
[1m>                   assert rule.stem in readme,\[0m
[1m                        'Missing rule "{}" in README.md'.format(rule.stem)[0m
[1m[31mE                   AssertionError: Missing rule "shoaib" in README.md[0m
[1m[31mE                   assert 'shoaib' in '# The Fuck [![Version][version-badge]][version-link] [![Build Status][travis-badge]][travis-link] [![Windows Build St...efuck/master/example_instant_mode.gif\n[homebrew]:        https://brew.sh/\n[linuxbrew]:       https://linuxbrew.sh/\n'[0m
[1m[31mE                    +  where 'shoaib' = PosixPath('/home/travis/build/nvbn/thefuck/thefuck/rules/shoaib.py').stem[0m

[1m[31mtests/test_readme.py[0m:11: AssertionError
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
tests/test_conf.py::test_get_user_dir_path[True-~/.config-~/.thefuck]
  /home/travis/build/nvbn/thefuck/thefuck/conf.py:53: UserWarning: Config path /home/travis/.thefuck is deprecated. Please move to /home/travis/.config/thefuck
    legacy_user_dir, user_dir))

tests/test_conf.py::test_get_user_dir_path[True-/user/test/config/-~/.thefuck]
  /home/travis/build/nvbn/thefuck/thefuck/conf.py:53: UserWarning: Config path /home/travis/.thefuck is deprecated. Please move to /user/test/config/thefuck
    legacy_user_dir, user_dir))

-- Docs: https://docs.pytest.org/en/latest/warnings.html
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 2-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/534333188.log

tests/specific/test_npm.py::test_get_scripts [32mPASSED[0m[36m                      [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-sudo ls-ls-sudo ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-ls-ls-ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[return_value2-sudo ls-ls-result2] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-sudo ls-ls-True] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-ls-ls-True] [32mPASSED[0m[36m   [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-sudo ls-ls-False] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-ls-ls-False] [32mPASSED[0m[36m [100%][0m

=================================== FAILURES ===================================
-=-=-=-=-=-

-=-=-=-=-=-
[31m[1m__________________________ TestGeneric.test_app_alias __________________________[0m

self = <tests.shells.test_generic.TestGeneric object at 0x7f0c5be9cf28>
shell = <thefuck.shells.generic.Generic object at 0x7f0c5bea00f0>

[1m    def test_app_alias(self, shell):[0m
[1m        assert 'alias fuck' in shell.app_alias('fuck')[0m
[1m        assert 'alias FUCK' in shell.app_alias('FUCK')[0m
[1m        assert 'thefuck' in shell.app_alias('fuck')[0m
[1m>       assert 'TF_ALIAS=fuck PYTHONIOENCODING' in shell.app_alias('fuck')[0m
[1m[31mE       assert 'TF_ALIAS=fuck PYTHONIOENCODING' in 'alias fuck=\'eval "$(TF_ALIAS=fuck" PYTHONIOENCODING=utf-8 thefuck "$(fc -ln -1))"\''[0m
[1m[31mE        +  where 'alias fuck=\'eval "$(TF_ALIAS=fuck" PYTHONIOENCODING=utf-8 thefuck "$(fc -ln -1))"\'' = <bound method Generic.app_alias of <thefuck.shells.generic.Generic object at 0x7f0c5bea00f0>>('fuck')[0m
[1m[31mE        +    where <bound method Generic.app_alias of <thefuck.shells.generic.Generic object at 0x7f0c5bea00f0>> = <thefuck.shells.generic.Generic object at 0x7f0c5bea00f0>.app_alias[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/shells/test_generic.py[0m:31: AssertionError
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:324
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:324: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:324
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:324: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

tests/test_conf.py::test_get_user_dir_path[True-~/.config-~/.thefuck]
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/537373579.log

collecting 271 items                                                           [0m[1m
collecting 746 items                                                           [0m[1m
collecting 905 items                                                           [0m[1m
collecting 1073 items                                                          [0m[1m
collecting 1270 items                                                          [0m[1m
collecting 1451 items                                                          [0m[1m
collecting 1601 items / 1 errors / 1600 selected                               [0m[1m
collected 1609 items / 1 errors / 1608 selected                                [0m

==================================== ERRORS ====================================
-=-=-=-=-=-

-=-=-=-=-=-
[1m[31m_______________ ERROR collecting tests/shells/test_powershell.py _______________[0m
[1m[31mtests/shells/test_powershell.py[0m:8: in <module>
[1m    class TestPowershell(object):[0m
[1m[31mtests/shells/test_powershell.py[0m:33: in TestPowershell
[1m    ([FileNotFoundError, b'PowerShell 6.1.2\n'], 'PowerShell 6.1.2', 'pwsh')])[0m
[1m[31mE   NameError: name 'FileNotFoundError' is not defined[0m
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324
  /home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324
  /home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

-- Docs: https://docs.pytest.org/en/latest/warnings.html
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 4-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/537374319.log

collecting 143 items                                                           [0m[1m
collecting 316 items                                                           [0m[1m
collecting 818 items                                                           [0m[1m
collecting 1019 items                                                          [0m[1m
collecting 1201 items                                                          [0m[1m
collecting 1414 items                                                          [0m[1m
collecting 1483 items                                                          [0m[1m
collected 1609 items / 1 errors / 1608 selected                                [0m

==================================== ERRORS ====================================
-=-=-=-=-=-

-=-=-=-=-=-
[1m[31m_______________ ERROR collecting tests/shells/test_powershell.py _______________[0m
[1m[31mtests/shells/test_powershell.py[0m:8: in <module>
[1m    class TestPowershell(object):[0m
[1m[31mtests/shells/test_powershell.py[0m:33: in TestPowershell
[1m    ([FileNotFoundError, b'PowerShell 6.1.2\n'], 'PowerShell 6.1.2', 'pwsh')])[0m
[1m[31mE   NameError: name 'FileNotFoundError' is not defined[0m
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324
  /home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324
  /home/travis/virtualenv/python2.7.14/lib/python2.7/site-packages/_pytest/mark/structures.py:324: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

-- Docs: https://docs.pytest.org/en/latest/warnings.html
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 5-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/540933341.log

tests/specific/test_npm.py::test_get_scripts [32mPASSED[0m[36m                      [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-sudo ls-ls-sudo ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-ls-ls-ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[return_value2-sudo ls-ls-result2] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-sudo ls-ls-True] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-ls-ls-True] [32mPASSED[0m[36m   [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-sudo ls-ls-False] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-ls-ls-False] [32mPASSED[0m[36m [100%][0m

==================================== ERRORS ====================================
-=-=-=-=-=-

-=-=-=-=-=-
[31m[1m____ ERROR at setup of test_get_new_command[command0-nix-env -iA nixos.vim] ____[0m
file /home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py, line 21
  @pytest.mark.parametrize('command, new_command', [
      (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),
      (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])
  def test_get_new_command(mocker, command, new_command, packages):
[31mE       fixture 'packages' not found[0m
[31m>       available fixtures: TIMEOUT, benchmark, benchmark_weave, cache, capfd, capfdbinary, caplog, capsys, capsysbinary, doctest_namespace, functional, mock, mocker, monkeypatch, no_cache, no_colors, no_memoize, once_without_docker, os_environ, pytestconfig, record_property, record_testsuite_property, record_xml_attribute, recwarn, run_without_docker, set_shell, settings, skip_without_docker, source_root, spawnu, tmp_path, tmp_path_factory, tmpdir, tmpdir_factory[0m
[31m>       use 'pytest --fixtures [testpath]' for help on them.[0m

/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py:21
[31m[1m__ ERROR at setup of test_get_new_command[command1-nix-env -iA nixos.pacman] ___[0m
file /home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py, line 21
  @pytest.mark.parametrize('command, new_command', [
      (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),
      (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])
  def test_get_new_command(mocker, command, new_command, packages):
[31mE       fixture 'packages' not found[0m
[31m>       available fixtures: TIMEOUT, benchmark, benchmark_weave, cache, capfd, capfdbinary, caplog, capsys, capsysbinary, doctest_namespace, functional, mock, mocker, monkeypatch, no_cache, no_colors, no_memoize, once_without_docker, os_environ, pytestconfig, record_property, record_testsuite_property, record_xml_attribute, recwarn, run_without_docker, set_shell, settings, skip_without_docker, source_root, spawnu, tmp_path, tmp_path_factory, tmpdir, tmpdir_factory[0m
[31m>       use 'pytest --fixtures [testpath]' for help on them.[0m

/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py:21
=================================== FAILURES ===================================
[31m[1m_________________________________ test_readme __________________________________[0m

source_root = PosixPath('/home/travis/build/nvbn/thefuck')

[1m    def test_readme(source_root):[0m
[1m        with source_root.joinpath('README.md').open() as f:[0m
[1m            readme = f.read()[0m
[1m    [0m
[1m            bundled = source_root.joinpath('thefuck') \[0m
[1m                                 .joinpath('rules') \[0m
[1m                                 .glob('*.py')[0m
[1m    [0m
[1m            for rule in bundled:[0m
[1m                if rule.stem != '__init__':[0m
[1m>                   assert rule.stem in readme,\[0m
[1m                        'Missing rule "{}" in README.md'.format(rule.stem)[0m
[1m[31mE                   AssertionError: Missing rule "nixos_cmd_not_found" in README.md[0m
[1m[31mE                   assert 'nixos_cmd_not_found' in '# The Fuck [![Version][version-badge]][version-link] [![Build Status][travis-badge]][travis-link] [![Windows Build St...efuck/master/example_instant_mode.gif\n[homebrew]:        https://brew.sh/\n[linuxbrew]:       https://linuxbrew.sh/\n'[0m
[1m[31mE                    +  where 'nixos_cmd_not_found' = PosixPath('/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py').stem[0m

[1m[31mtests/test_readme.py[0m:11: AssertionError
[31m[1m_____________________________ test_match[command0] _____________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f61e161cb00>
command = (Command(script=vim, output=nix-env -iA nixos.vim),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'),)])[0m
[1m    def test_match(mocker, command):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=None)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:9: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7f61e15ae898>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
[31m[1m________________________ test_not_match[command0-None] _________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f61e17496a0>
command = Command(script=vim, output=), which = None

[1m    @pytest.mark.parametrize('command, which', [[0m
[1m        (Command('vim', ''), None),[0m
[1m        (Command('', ''), None)])[0m
[1m    def test_not_match(mocker, command, which):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=which)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:17: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7f61e1749710>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
[31m[1m________________________ test_not_match[command1-None] _________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f61e12fc860>
command = Command(script=, output=), which = None

[1m    @pytest.mark.parametrize('command, which', [[0m
[1m        (Command('vim', ''), None),[0m
[1m        (Command('', ''), None)])[0m
[1m    def test_not_match(mocker, command, which):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=which)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:17: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7f61e12fc8d0>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

tests/test_conf.py::test_get_user_dir_path[True-~/.config-~/.thefuck]
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 6-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/540934200.log

tests/specific/test_npm.py::test_get_scripts [32mPASSED[0m[36m                      [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-sudo ls-ls-sudo ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-ls-ls-ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[return_value2-sudo ls-ls-result2] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-sudo ls-ls-True] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-ls-ls-True] [32mPASSED[0m[36m   [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-sudo ls-ls-False] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-ls-ls-False] [32mPASSED[0m[36m [100%][0m

==================================== ERRORS ====================================
-=-=-=-=-=-

-=-=-=-=-=-
[31m[1m____ ERROR at setup of test_get_new_command[command0-nix-env -iA nixos.vim] ____[0m
file /home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py, line 21
  @pytest.mark.parametrize('command, new_command', [
      (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),
      (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])
  def test_get_new_command(mocker, command, new_command, packages):
[31mE       fixture 'packages' not found[0m
[31m>       available fixtures: TIMEOUT, benchmark, benchmark_weave, cache, capfd, capfdbinary, caplog, capsys, capsysbinary, doctest_namespace, functional, mock, mocker, monkeypatch, no_cache, no_colors, no_memoize, once_without_docker, os_environ, pytestconfig, record_property, record_testsuite_property, record_xml_attribute, recwarn, run_without_docker, set_shell, settings, skip_without_docker, source_root, spawnu, tmp_path, tmp_path_factory, tmpdir, tmpdir_factory[0m
[31m>       use 'pytest --fixtures [testpath]' for help on them.[0m

/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py:21
[31m[1m__ ERROR at setup of test_get_new_command[command1-nix-env -iA nixos.pacman] ___[0m
file /home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py, line 21
  @pytest.mark.parametrize('command, new_command', [
      (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),
      (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])
  def test_get_new_command(mocker, command, new_command, packages):
[31mE       fixture 'packages' not found[0m
[31m>       available fixtures: TIMEOUT, benchmark, benchmark_weave, cache, capfd, capfdbinary, caplog, capsys, capsysbinary, doctest_namespace, functional, mock, mocker, monkeypatch, no_cache, no_colors, no_memoize, once_without_docker, os_environ, pytestconfig, record_property, record_testsuite_property, record_xml_attribute, recwarn, run_without_docker, set_shell, settings, skip_without_docker, source_root, spawnu, tmp_path, tmp_path_factory, tmpdir, tmpdir_factory[0m
[31m>       use 'pytest --fixtures [testpath]' for help on them.[0m

/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py:21
=================================== FAILURES ===================================
[31m[1m_________________________________ test_readme __________________________________[0m

source_root = PosixPath('/home/travis/build/nvbn/thefuck')

[1m    def test_readme(source_root):[0m
[1m        with source_root.joinpath('README.md').open() as f:[0m
[1m            readme = f.read()[0m
[1m    [0m
[1m            bundled = source_root.joinpath('thefuck') \[0m
[1m                                 .joinpath('rules') \[0m
[1m                                 .glob('*.py')[0m
[1m    [0m
[1m            for rule in bundled:[0m
[1m                if rule.stem != '__init__':[0m
[1m>                   assert rule.stem in readme,\[0m
[1m                        'Missing rule "{}" in README.md'.format(rule.stem)[0m
[1m[31mE                   AssertionError: Missing rule "nixos_cmd_not_found" in README.md[0m
[1m[31mE                   assert 'nixos_cmd_not_found' in '# The Fuck [![Version][version-badge]][version-link] [![Build Status][travis-badge]][travis-link] [![Windows Build St...efuck/master/example_instant_mode.gif\n[homebrew]:        https://brew.sh/\n[linuxbrew]:       https://linuxbrew.sh/\n'[0m
[1m[31mE                    +  where 'nixos_cmd_not_found' = PosixPath('/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py').stem[0m

[1m[31mtests/test_readme.py[0m:11: AssertionError
[31m[1m_____________________________ test_match[command0] _____________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7fc3ae625860>
command = (Command(script=vim, output=nix-env -iA nixos.vim),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'),)])[0m
[1m    def test_match(mocker, command):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=None)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:9: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7fc3ae625908>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
[31m[1m________________________ test_not_match[command0-None] _________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7fc3ae76de10>
command = Command(script=vim, output=), which = None

[1m    @pytest.mark.parametrize('command, which', [[0m
[1m        (Command('vim', ''), None),[0m
[1m        (Command('', ''), None)])[0m
[1m    def test_not_match(mocker, command, which):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=which)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:17: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7fc3ae5fabe0>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
[31m[1m________________________ test_not_match[command1-None] _________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7fc3ae684d68>
command = Command(script=, output=), which = None

[1m    @pytest.mark.parametrize('command, which', [[0m
[1m        (Command('vim', ''), None),[0m
[1m        (Command('', ''), None)])[0m
[1m    def test_not_match(mocker, command, which):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=which)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:17: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7fc3ae64a278>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

tests/test_conf.py::test_get_user_dir_path[True-~/.config-~/.thefuck]
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 7-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/540939093.log

tests/specific/test_npm.py::test_get_scripts [32mPASSED[0m[36m                      [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-sudo ls-ls-sudo ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-ls-ls-ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[return_value2-sudo ls-ls-result2] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-sudo ls-ls-True] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-ls-ls-True] [32mPASSED[0m[36m   [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-sudo ls-ls-False] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-ls-ls-False] [32mPASSED[0m[36m [100%][0m

=================================== FAILURES ===================================
-=-=-=-=-=-

-=-=-=-=-=-
[31m[1m_________________________________ test_readme __________________________________[0m

source_root = PosixPath('/home/travis/build/nvbn/thefuck')

[1m    def test_readme(source_root):[0m
[1m        with source_root.joinpath('README.md').open() as f:[0m
[1m            readme = f.read()[0m
[1m    [0m
[1m            bundled = source_root.joinpath('thefuck') \[0m
[1m                                 .joinpath('rules') \[0m
[1m                                 .glob('*.py')[0m
[1m    [0m
[1m            for rule in bundled:[0m
[1m                if rule.stem != '__init__':[0m
[1m>                   assert rule.stem in readme,\[0m
[1m                        'Missing rule "{}" in README.md'.format(rule.stem)[0m
[1m[31mE                   AssertionError: Missing rule "nixos_cmd_not_found" in README.md[0m
[1m[31mE                   assert 'nixos_cmd_not_found' in '# The Fuck [![Version][version-badge]][version-link] [![Build Status][travis-badge]][travis-link] [![Windows Build St...efuck/master/example_instant_mode.gif\n[homebrew]:        https://brew.sh/\n[linuxbrew]:       https://linuxbrew.sh/\n'[0m
[1m[31mE                    +  where 'nixos_cmd_not_found' = PosixPath('/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py').stem[0m

[1m[31mtests/test_readme.py[0m:11: AssertionError
[31m[1m_____________________________ test_match[command0] _____________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f855cd6d0b8>
command = (Command(script=vim, output=nix-env -iA nixos.vim),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'),)])[0m
[1m    def test_match(mocker, command):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=None)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:9: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7f855cd6d588>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
[31m[1m___________________________ test_not_match[command0] ___________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f855c14e208>
command = (Command(script=vim, output=),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', ''),),[0m
[1m        (Command('', ''),)])[0m
[1m    def test_not_match(mocker, command):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=None)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:17: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7f855c14e1d0>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
[31m[1m___________________________ test_not_match[command1] ___________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f855c2e9ac8>
command = (Command(script=, output=),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', ''),),[0m
[1m        (Command('', ''),)])[0m
[1m    def test_not_match(mocker, command):[0m
[1m>       mocker.patch('thefuck.rules.nixos_cmd_not_found.which', return_value=None)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:17: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:158: in __call__
[1m    return self._start_patch(self.mock_module.patch, *args, **kwargs)[0m
[1m[31m/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/pytest_mock.py[0m:138: in _start_patch
[1m    mocked = p.start()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1386: in start
[1m    result = self.__enter__()[0m
[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1255: in __enter__
[1m    original, local = self.get_original()[0m
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

self = <unittest.mock._patch object at 0x7f855c2e9c18>

[1m    def get_original(self):[0m
[1m        target = self.getter()[0m
[1m        name = self.attribute[0m
[1m    [0m
[1m        original = DEFAULT[0m
[1m        local = False[0m
[1m    [0m
[1m        try:[0m
[1m            original = target.__dict__[name][0m
[1m        except (AttributeError, KeyError):[0m
[1m            original = getattr(target, name, DEFAULT)[0m
[1m        else:[0m
[1m            local = True[0m
[1m    [0m
[1m        if name in _builtins and isinstance(target, ModuleType):[0m
[1m            self.create = True[0m
[1m    [0m
[1m        if not self.create and original is DEFAULT:[0m
[1m            raise AttributeError([0m
[1m>               "%s does not have the attribute %r" % (target, name)[0m
[1m            )[0m
[1m[31mE           AttributeError: <module 'thefuck.rules.nixos_cmd_not_found' from '/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py'> does not have the attribute 'which'[0m

[1m[31m/opt/python/3.7.1/lib/python3.7/unittest/mock.py[0m:1229: AttributeError
[31m[1m_____________ test_get_new_command[command0-nix-env -iA nixos.vim] _____________[0m

mocker = <pytest_mock.MockFixture object at 0x7f855c35f518>
command = Command(script=vim, output=nix-env -iA nixos.vim)
new_command = 'nix-env -iA nixos.vim'

[1m    @pytest.mark.parametrize('command, new_command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),[0m
[1m        (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])[0m
[1m    def test_get_new_command(mocker, command, new_command):[0m
[1m>       assert get_new_command(command) == new_command[0m
[1m[31mE       AssertionError: assert 'nix-env -iA nixos.vim && vim' == 'nix-env -iA nixos.vim'[0m
[1m[31mE         - nix-env -iA nixos.vim && vim[0m
[1m[31mE         ?                      -------[0m
[1m[31mE         + nix-env -iA nixos.vim[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:25: AssertionError
[31m[1m___________ test_get_new_command[command1-nix-env -iA nixos.pacman] ____________[0m

mocker = <pytest_mock.MockFixture object at 0x7f855c3c8630>
command = Command(script=pacman, output=nix-env -iA nixos.pacman)
new_command = 'nix-env -iA nixos.pacman'

[1m    @pytest.mark.parametrize('command, new_command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),[0m
[1m        (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])[0m
[1m    def test_get_new_command(mocker, command, new_command):[0m
[1m>       assert get_new_command(command) == new_command[0m
[1m[31mE       AssertionError: assert 'nix-env -iA ...man && pacman' == 'nix-env -iA nixos.pacman'[0m
[1m[31mE         - nix-env -iA nixos.pacman && pacman[0m
[1m[31mE         ?                         ----------[0m
[1m[31mE         + nix-env -iA nixos.pacman[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:25: AssertionError
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

tests/test_conf.py::test_get_user_dir_path[True-~/.config-~/.thefuck]
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 8-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/540943480.log

tests/specific/test_npm.py::test_get_scripts [32mPASSED[0m[36m                      [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-sudo ls-ls-sudo ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-ls-ls-ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[return_value2-sudo ls-ls-result2] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-sudo ls-ls-True] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-ls-ls-True] [32mPASSED[0m[36m   [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-sudo ls-ls-False] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-ls-ls-False] [32mPASSED[0m[36m [100%][0m

=================================== FAILURES ===================================
-=-=-=-=-=-

-=-=-=-=-=-
[31m[1m_________________________________ test_readme __________________________________[0m

source_root = PosixPath('/home/travis/build/nvbn/thefuck')

[1m    def test_readme(source_root):[0m
[1m        with source_root.joinpath('README.md').open() as f:[0m
[1m            readme = f.read()[0m
[1m    [0m
[1m            bundled = source_root.joinpath('thefuck') \[0m
[1m                                 .joinpath('rules') \[0m
[1m                                 .glob('*.py')[0m
[1m    [0m
[1m            for rule in bundled:[0m
[1m                if rule.stem != '__init__':[0m
[1m>                   assert rule.stem in readme,\[0m
[1m                        'Missing rule "{}" in README.md'.format(rule.stem)[0m
[1m[31mE                   AssertionError: Missing rule "nixos_cmd_not_found" in README.md[0m
[1m[31mE                   assert 'nixos_cmd_not_found' in '# The Fuck [![Version][version-badge]][version-link] [![Build Status][travis-badge]][travis-link] [![Windows Build St...efuck/master/example_instant_mode.gif\n[homebrew]:        https://brew.sh/\n[linuxbrew]:       https://linuxbrew.sh/\n'[0m
[1m[31mE                    +  where 'nixos_cmd_not_found' = PosixPath('/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py').stem[0m

[1m[31mtests/test_readme.py[0m:11: AssertionError
[31m[1m_____________________________ test_match[command0] _____________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f535b2eac50>
command = (Command(script=vim, output=nix-env -iA nixos.vim),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'),)])[0m
[1m    def test_match(mocker, command):[0m
[1m        mocker.patch('thefuck.rules.nixos_cmd_not_found', return_value=None)[0m
[1m>       assert match(command)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:10: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

command = (Command(script=vim, output=nix-env -iA nixos.vim),)

[1m    def match(command):[0m
[1m>       return regex.findall(command.output)[0m
[1m[31mE       AttributeError: 'tuple' object has no attribute 'output'[0m

[1m[31m/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py[0m:10: AttributeError
[31m[1m___________________________ test_not_match[command0] ___________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f535bc3c9b0>
command = (Command(script=vim, output=),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', ''),),[0m
[1m        (Command('', ''),)])[0m
[1m    def test_not_match(mocker, command):[0m
[1m        mocker.patch('thefuck.rules.nixos_cmd_not_found', return_value=None)[0m
[1m>       assert not match(command)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:18: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

command = (Command(script=vim, output=),)

[1m    def match(command):[0m
[1m>       return regex.findall(command.output)[0m
[1m[31mE       AttributeError: 'tuple' object has no attribute 'output'[0m

[1m[31m/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py[0m:10: AttributeError
[31m[1m___________________________ test_not_match[command1] ___________________________[0m

mocker = <pytest_mock.MockFixture object at 0x7f535b337390>
command = (Command(script=, output=),)

[1m    @pytest.mark.parametrize('command', [[0m
[1m        (Command('vim', ''),),[0m
[1m        (Command('', ''),)])[0m
[1m    def test_not_match(mocker, command):[0m
[1m        mocker.patch('thefuck.rules.nixos_cmd_not_found', return_value=None)[0m
[1m>       assert not match(command)[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:18: 
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

command = (Command(script=, output=),)

[1m    def match(command):[0m
[1m>       return regex.findall(command.output)[0m
[1m[31mE       AttributeError: 'tuple' object has no attribute 'output'[0m

[1m[31m/home/travis/build/nvbn/thefuck/thefuck/rules/nixos_cmd_not_found.py[0m:10: AttributeError
[31m[1m_____________ test_get_new_command[command0-nix-env -iA nixos.vim] _____________[0m

mocker = <pytest_mock.MockFixture object at 0x7f535b2abbe0>
command = Command(script=vim, output=nix-env -iA nixos.vim)
new_command = 'nix-env -iA nixos.vim'

[1m    @pytest.mark.parametrize('command, new_command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),[0m
[1m        (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])[0m
[1m    def test_get_new_command(mocker, command, new_command):[0m
[1m>       assert get_new_command(command) == new_command[0m
[1m[31mE       AssertionError: assert 'nix-env -iA nixos.vim && vim' == 'nix-env -iA nixos.vim'[0m
[1m[31mE         - nix-env -iA nixos.vim && vim[0m
[1m[31mE         ?                      -------[0m
[1m[31mE         + nix-env -iA nixos.vim[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:25: AssertionError
[31m[1m___________ test_get_new_command[command1-nix-env -iA nixos.pacman] ____________[0m

mocker = <pytest_mock.MockFixture object at 0x7f535b3420b8>
command = Command(script=pacman, output=nix-env -iA nixos.pacman)
new_command = 'nix-env -iA nixos.pacman'

[1m    @pytest.mark.parametrize('command, new_command', [[0m
[1m        (Command('vim', 'nix-env -iA nixos.vim'), 'nix-env -iA nixos.vim'),[0m
[1m        (Command('pacman', 'nix-env -iA nixos.pacman'), 'nix-env -iA nixos.pacman')])[0m
[1m    def test_get_new_command(mocker, command, new_command):[0m
[1m>       assert get_new_command(command) == new_command[0m
[1m[31mE       AssertionError: assert 'nix-env -iA ...man && pacman' == 'nix-env -iA nixos.pacman'[0m
[1m[31mE         - nix-env -iA nixos.pacman && pacman[0m
[1m[31mE         ?                         ----------[0m
[1m[31mE         + nix-env -iA nixos.pacman[0m

[1m[31m/home/travis/build/nvbn/thefuck/tests/rules/test_nixos_cmd_not_found.py[0m:25: AssertionError
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:337: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

tests/test_conf.py::test_get_user_dir_path[True-~/.config-~/.thefuck]
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 9-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/545320732.log

Finished processing dependencies for thefuck==3.29
travis_time:end:2402d3b0:start=1560440993463011175,finish=1560440998013010609,duration=4549999434
[0Ktravis_fold:end:install.2
[0Ktravis_fold:start:install.3
[0Ktravis_time:start:25c020dc
[0K$ rm -rf build
travis_time:end:25c020dc:start=1560440998023584914,finish=1560440998027583482,duration=3998568
[0Ktravis_fold:end:install.3
[0Ktravis_time:start:08124bcd
[0K$ flake8
-=-=-=-=-=-

-=-=-=-=-=-
./thefuck/rules/terraform_init.py:8:9: E128 continuation line under-indented for visual indent
./thefuck/rules/terraform_init.py:9:5: E124 closing bracket does not match visual indentation
-=-=-=-=-=-

-=-=-=-=-=-
travis_time:end:08124bcd:start=1560440998046379375,finish=1560441001950129095,duration=3903749720
[0K[31;1mThe command "flake8" exited with 1.[0m

travis_time:start:106e7a18
[0K$ export COVERAGE_PYTHON_VERSION=python-${TRAVIS_PYTHON_VERSION:0:1}
travis_time:end:106e7a18:start=1560441001960150028,finish=1560441001963098998,duration=2948970
[0K[32;1mThe command "export COVERAGE_PYTHON_VERSION=python-${TRAVIS_PYTHON_VERSION:0:1}" exited with 0.[0m

travis_time:start:029bc664
[0K$ export RUN_TESTS="coverage run --source=thefuck,tests -m py.test -v --capture=sys tests"
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 10-=-=-=-=-=--=-=-=-=-=-
Input path: Python/nvbn@thefuck/failed/554824331.log

tests/specific/test_npm.py::test_get_scripts [32mPASSED[0m[36m                      [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-sudo ls-ls-sudo ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[ls -lah-ls-ls-ls -lah] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[return_value2-sudo ls-ls-result2] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-sudo ls-ls-True] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[True-ls-ls-True] [32mPASSED[0m[36m   [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-sudo ls-ls-False] [32mPASSED[0m[36m [ 99%][0m
tests/specific/test_sudo.py::test_sudo_support[False-ls-ls-False] [32mPASSED[0m[36m [100%][0m

=================================== FAILURES ===================================
-=-=-=-=-=-

-=-=-=-=-=-
[31m[1m_________________________________ test_readme __________________________________[0m

source_root = PosixPath('/home/travis/build/nvbn/thefuck')

[1m    def test_readme(source_root):[0m
[1m        with source_root.joinpath('README.md').open() as f:[0m
[1m            readme = f.read()[0m
[1m    [0m
[1m            bundled = source_root.joinpath('thefuck') \[0m
[1m                                 .joinpath('rules') \[0m
[1m                                 .glob('*.py')[0m
[1m    [0m
[1m            for rule in bundled:[0m
[1m                if rule.stem != '__init__':[0m
[1m>                   assert rule.stem in readme,\[0m
[1m                        'Missing rule "{}" in README.md'.format(rule.stem)[0m
[1m[31mE                   AssertionError: Missing rule "docker_image_being_used_by_container" in README.md[0m
[1m[31mE                   assert 'docker_image_being_used_by_container' in '# The Fuck [![Version][version-badge]][version-link] [![Build Status][travis-badge]][travis-link] [![Windows Build St...efuck/master/example_instant_mode.gif\n[homebrew]:        https://brew.sh/\n[linuxbrew]:       https://linuxbrew.sh/\n'[0m
[1m[31mE                    +  where 'docker_image_being_used_by_container' = PosixPath('/home/travis/build/nvbn/thefuck/thefuck/rules/docker_image_being_used_by_container.py').stem[0m

[1m[31mtests/test_readme.py[0m:11: AssertionError
-=-=-=-=-=-

-=-=-=-=-=-
[33m=============================== warnings summary ===============================[0m
/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:332
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:332: PytestUnknownMarkWarning: Unknown pytest.mark.usefixture - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

/home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:332
  /home/travis/virtualenv/python3.7.1/lib/python3.7/site-packages/_pytest/mark/structures.py:332: PytestUnknownMarkWarning: Unknown pytest.mark.functional - is this a typo?  You can register custom marks to avoid this warning - for details, see https://docs.pytest.org/en/latest/mark.html
    PytestUnknownMarkWarning,

tests/test_conf.py::test_get_user_dir_path[True-~/.config-~/.thefuck]
```

##### Category
→←

#### BuildFailureReason/Swift/Alamofire@Alamofire
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 1-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/552510229.log

[39;1mUploadStreamInitializationTestCase[0m

    [32;1m✓[0m testUploadClassMethodWithMethodURLAndStream ([33m0.045[0m seconds)

    [32;1m✓[0m testUploadClassMethodWithMethodURLHeadersAndStream ([33m0.044[0m seconds)





-=-=-=-=-=-

-=-=-=-=-=-
Alamofire_iOS_Tests.SessionTestCase

  testThatDataRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertTrue failed[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:550[0m

  qqq

[38;5;230m        [39m[38;5;221;01mif[39;00m[38;5;230m [39m[38;5;221;01mlet[39;00m[38;5;230m [39m[38;5;153;01merror[39;00m[38;5;230m [39m[38;5;87m=[39m[38;5;230m [39m[38;5;230mresponse[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230merror[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230masAFError[39m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m[39m  qqq



  testThatDataRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertEqual failed: ("nil") is not equal to ("Optional("https://httpbin.org/get/äëïöü")")[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:551[0m

  qqq

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m        [39m[38;5;87m}[39m[38;5;230m [39m[38;5;221;01melse[39;00m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m[39m  qqq



  testThatUploadFileRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertTrue failed[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:638[0m

  qqq

[38;5;230m        [39m[38;5;221;01mif[39;00m[38;5;230m [39m[38;5;221;01mlet[39;00m[38;5;230m [39m[38;5;153;01merror[39;00m[38;5;230m [39m[38;5;87m=[39m[38;5;230m [39m[38;5;230mresponse[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230merror[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230masAFError[39m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m[39m  qqq



  testThatUploadFileRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertEqual failed: ("nil") is not equal to ("Optional("https://httpbin.org/get/äëïöü")")[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:639[0m

  qqq

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m        [39m[38;5;87m}[39m[38;5;230m [39m[38;5;221;01melse[39;00m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m[39m  qqq
-=-=-=-=-=-

-=-=-=-=-=-





[31m	 Executed 528 tests, with 4 failures (0 unexpected) in 31.322 (32.473) seconds

[0m

2019-06-30 21:29:16.728 xcodebuild[3106:7441]  IDETestOperationsObserverDebug: Failure collecting logarchive: Test daemon protocol version 22 is too old to support log archive collection (minimum 26)
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 2-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/553190487.log

[39;1mUploadStreamInitializationTestCase[0m

    [32;1m✓[0m testUploadClassMethodWithMethodURLAndStream ([33m0.051[0m seconds)

    [32;1m✓[0m testUploadClassMethodWithMethodURLHeadersAndStream ([33m0.047[0m seconds)





-=-=-=-=-=-

-=-=-=-=-=-
Alamofire_macOS_Tests.SessionTestCase

  testThatDataRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertTrue failed[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:550[0m

  qqq

[38;5;230m        [39m[38;5;221;01mif[39;00m[38;5;230m [39m[38;5;221;01mlet[39;00m[38;5;230m [39m[38;5;153;01merror[39;00m[38;5;230m [39m[38;5;87m=[39m[38;5;230m [39m[38;5;230mresponse[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230merror[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230masAFError[39m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m[39m  qqq



  testThatDataRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertEqual failed: ("nil") is not equal to ("Optional("https://httpbin.org/get/äëïöü")")[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:551[0m

  qqq

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m        [39m[38;5;87m}[39m[38;5;230m [39m[38;5;221;01melse[39;00m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m[39m  qqq



  testThatDownloadRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertTrue failed[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:580[0m

  qqq

[38;5;230m        [39m[38;5;221;01mif[39;00m[38;5;230m [39m[38;5;221;01mlet[39;00m[38;5;230m [39m[38;5;153;01merror[39;00m[38;5;230m [39m[38;5;87m=[39m[38;5;230m [39m[38;5;230mresponse[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230merror[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230masAFError[39m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m[39m  qqq



  testThatDownloadRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertEqual failed: ("nil") is not equal to ("Optional("https://httpbin.org/get/äëïöü")")[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:581[0m

  qqq

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m        [39m[38;5;87m}[39m[38;5;230m [39m[38;5;221;01melse[39;00m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m[39m  qqq
-=-=-=-=-=-

-=-=-=-=-=-





[31m	 Executed 520 tests, with 4 failures (0 unexpected) in 28.911 (29.874) seconds

[0m

2019-07-02 09:36:06.594 xcodebuild[6906:13570] [MT] IDETestOperationsObserverDebug: 33.267 elapsed -- Testing started completed.
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/555938247.log

[39;1mUploadStreamInitializationTestCase[0m

    [32;1m✓[0m testUploadClassMethodWithMethodURLAndStream ([33m0.048[0m seconds)

    [32;1m✓[0m testUploadClassMethodWithMethodURLHeadersAndStream ([31m0.127[0m seconds)





-=-=-=-=-=-

-=-=-=-=-=-
Alamofire_iOS_Tests.SessionTestCase

  testThatDownloadRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertTrue failed[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:580[0m

  qqq

[38;5;230m        [39m[38;5;221;01mif[39;00m[38;5;230m [39m[38;5;221;01mlet[39;00m[38;5;230m [39m[38;5;153;01merror[39;00m[38;5;230m [39m[38;5;87m=[39m[38;5;230m [39m[38;5;230mresponse[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230merror[39m[38;5;87m?[39m[38;5;87m.[39m[38;5;230masAFError[39m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m[39m  qqq



  testThatDownloadRequestWithInvalidURLStringThrowsResponseHandlerError, [31mXCTAssertEqual failed: ("nil") is not equal to ("Optional("https://httpbin.org/get/äëïöü")")[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/SessionTests.swift:581[0m

  qqq

[38;5;230m            [39m[38;5;155;01mXCTAssertTrue[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230misInvalidURLError[39m[38;5;87m)[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230merror[39m[38;5;87m.[39m[38;5;230murlConvertible[39m[38;5;230m [39m[38;5;221;01mas?[39;00m[38;5;230m [39m[38;5;155;01mString[39;00m[38;5;87m,[39m[38;5;230m [39m[38;5;229;01m"https://httpbin.org/get/äëïöü"[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m        [39m[38;5;87m}[39m[38;5;230m [39m[38;5;221;01melse[39;00m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m[39m  qqq
-=-=-=-=-=-

-=-=-=-=-=-





[31m	 Executed 528 tests, with 2 failures (0 unexpected) in 33.103 (34.874) seconds

[0m

2019-07-08 19:05:28.656 xcodebuild[3095:9101]  IDETestOperationsObserverDebug: Failure collecting logarchive: Test daemon protocol version 22 is too old to support log archive collection (minimum 26)
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 4-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/556020562.log

[39;1mRequestResponseTestCase[0m

    [32;1m✓[0m testPOSTRequestWithBase64EncodedImages ([31m0.352[0m seconds)

    [32;1m✓[0m testPOSTRequestWithUnicodeParameters ([33m0.047[0m seconds)

    [32;1m✓[0m testRequestResponse ([33m0.045[0m seconds)

    [32;1m✓[0m testRequestResponseWithProgress ([31m0.176[0m seconds)

-=-=-=-=-=-

-=-=-=-=-=-
2019-07-08 22:26:27.058 xcodebuild[3101:9336]  IDETestOperationsObserverDebug: Writing diagnostic log for test session to:

/Users/travis/Library/Developer/Xcode/DerivedData/Alamofire-cluwyoqdwcygxscxntjkvgncyhpi/Logs/Test/Test-Alamofire iOS-2019.07.08_22-21-36-+0000.xcresult/1_Test/Diagnostics/Alamofire iOS Tests-EBA5CCB7-4883-49E5-AC04-1DB24D54D147/Alamofire iOS Tests-59731680-66FE-4F36-AB77-DE642E8EBCE1/Session-Alamofire iOS Tests-2019-07-08_222627-wlFZP9.log

2019-07-08 22:26:27.059 xcodebuild[3101:7180] [MT] IDETestOperationsObserverDebug: (D4E0A4AF-BB1E-44FF-877B-E927EB495B21) Beginning test session Alamofire iOS Tests-D4E0A4AF-BB1E-44FF-877B-E927EB495B21 at 2019-07-08 22:26:27.059 with Xcode 10E1001 on target <DVTiPhoneSimulator: 0x7fd8c95694a0> {

		SimDevice: iPhone Xs (2D144036-DB57-4CBC-BC76-3452C2DCC7EB, iOS 12.2, Booted)

} (12.2 (16E226))

2019-07-08 22:26:27.071 xcodebuild[3101:7180] [MT] IDETestOperationsObserverDebug: (D4E0A4AF-BB1E-44FF-877B-E927EB495B21) Finished requesting crash reports. Continuing with testing.

    [31m✗[0m testThatAppendingResponseSerializerToCancelledRequestCallsCompletion, Test crashed
-=-=-=-=-=-

-=-=-=-=-=-

[39;1mSelected tests[0m

Test Suite [39;1mAlamofire iOS Tests.xctest[0m started

[39;1mRequestResponseTestCase[0m

    [32;1m✓[0m testThatAppendingResponseSerializerToCompletedRequestInsideCompletionResumesRequest ([31m0.232[0m seconds)

    [32;1m✓[0m testThatAppendingResponseSerializerToCompletedRequestOutsideCompletionResumesRequest ([31m0.181[0m seconds)
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 5-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/556112835.log

[39;1mUploadStreamInitializationTestCase[0m

    [32;1m✓[0m testUploadClassMethodWithMethodURLAndStream ([33m0.051[0m seconds)

    [32;1m✓[0m testUploadClassMethodWithMethodURLHeadersAndStream ([33m0.054[0m seconds)





-=-=-=-=-=-

-=-=-=-=-=-
Alamofire_iOS_Tests.StatusCodeValidationTestCase

  testThatValidationForRequestWithAcceptableStatusCodeResponseSucceeds, [31mAsynchronous wait failed: Exceeded timeout of 5 seconds, with unfulfilled expectations: "download should return 200 status code".[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/ValidationTests.swift:55[0m

  qqq

[38;5;230m

[38;5;230m        [39m[38;5;153mwaitForExpectations[39m[38;5;87m([39m[38;5;153;01mtimeout[39;00m[38;5;87m:[39m[38;5;230m [39m[38;5;230mtimeout[39m[38;5;87m,[39m[38;5;230m [39m[38;5;153;01mhandler[39;00m[38;5;87m:[39m[38;5;230m [39m[38;5;212;01mnil[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m

[38;5;230m[39m  qqq
-=-=-=-=-=-

-=-=-=-=-=-





[31m	 Executed 528 tests, with 1 failure (0 unexpected) in 44.353 (45.598) seconds

[0m

2019-07-09 04:30:21.803 xcodebuild[3107:8086]  IDETestOperationsObserverDebug: Failure collecting logarchive: Test daemon protocol version 22 is too old to support log archive collection (minimum 26)
```

##### Category
→←

##### BuildFailureReason & Context
```
=-=-=-=-=--=-=-=-=-=-Example 6-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/559137810.log

[39;1mUploadStreamInitializationTestCase[0m

    [32;1m✓[0m testUploadClassMethodWithMethodURLAndStream ([33m0.057[0m seconds)

    [32;1m✓[0m testUploadClassMethodWithMethodURLHeadersAndStream ([33m0.053[0m seconds)





-=-=-=-=-=-

-=-=-=-=-=-
Alamofire_iOS_Tests.UploadRequestEventsTestCase

  testThatCancelledUploadRequestTriggersAllAppropriateLifetimeEvents, [31mAsynchronous wait failed: Exceeded timeout of 5 seconds, with unfulfilled expectations: "didCancel should fire", "didCancelTask should fire".[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/UploadTests.swift:741[0m

  qqq

[38;5;230m

[38;5;230m        [39m[38;5;153mwaitForExpectations[39m[38;5;87m([39m[38;5;153;01mtimeout[39;00m[38;5;87m:[39m[38;5;230m [39m[38;5;230mtimeout[39m[38;5;87m,[39m[38;5;230m [39m[38;5;153;01mhandler[39;00m[38;5;87m:[39m[38;5;230m [39m[38;5;212;01mnil[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m

[38;5;230m[39m  qqq



  testThatCancelledUploadRequestTriggersAllAppropriateLifetimeEvents, [31mXCTAssertEqual failed: ("finished") is not equal to ("cancelled")[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/UploadTests.swift:744[0m

  qqq

[38;5;230m        [39m[38;5;67;04m// Then[39;00m[38;5;230m

[38;5;230m        [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230mrequest[39m[38;5;87m.[39m[38;5;230mstate[39m[38;5;87m,[39m[38;5;230m [39m[38;5;87m.[39m[38;5;230mcancelled[39m[38;5;87m)[39m[38;5;230m

[38;5;230m    [39m[38;5;87m}[39m[38;5;230m

[38;5;230m[39m  qqq
-=-=-=-=-=-

-=-=-=-=-=-





[31m	 Executed 531 tests, with 2 failures (0 unexpected) in 38.737 (39.939) seconds

[0m

2019-07-15 21:31:58.495 xcodebuild[3105:8073]  IDETestOperationsObserverDebug: Failure collecting logarchive: Test daemon protocol version 22 is too old to support log archive collection (minimum 26)
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 7-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/562608867.log

    [32;1m✓[0m testThatSessionRedirectHandlerCanModifyRedirects ([31m0.323[0m seconds)

    [32;1m✓[0m testThatSessionRedirectHandlerCanNotFollowRedirects ([31m0.146[0m seconds)

[39;1mRequestCURLDescriptionTestCase[0m

    [32;1m✓[0m testGETRequestCURLDescription (0.005 seconds)

    [32;1m✓[0m testGETRequestCURLDescriptionCanBeRequestedManyTimes (0.013 seconds)

-=-=-=-=-=-

-=-=-=-=-=-
2019-07-23 14:21:34.571 xcodebuild[3111:8516]  IDETestOperationsObserverDebug: Writing diagnostic log for test session to:

/Users/travis/Library/Developer/Xcode/DerivedData/Alamofire-cluwyoqdwcygxscxntjkvgncyhpi/Logs/Test/Test-Alamofire tvOS-2019.07.23_14-19-04-+0000.xcresult/1_Test/Diagnostics/Alamofire tvOS Tests-3453F750-CFB3-45CE-9371-8487B97D670B/Alamofire tvOS Tests-ED9BF638-571A-496D-9FAF-A3CB60F55EBD/Session-Alamofire tvOS Tests-2019-07-23_142134-SbJ3ll.log

2019-07-23 14:21:34.571 xcodebuild[3111:7195] [MT] IDETestOperationsObserverDebug: (351B9941-B174-4A38-8A4C-50C60B770796) Beginning test session Alamofire tvOS Tests-351B9941-B174-4A38-8A4C-50C60B770796 at 2019-07-23 14:21:34.571 with Xcode 10E1001 on target <DVTiPhoneSimulator: 0x7f81285e7c00> {

		SimDevice: Apple TV 1080p (456EC0CF-C098-4EC1-890E-4DE0BD3C4527, tvOS 10.2, Booted)

} (10.2 (14W260))

2019-07-23 14:21:34.580 xcodebuild[3111:7195] [MT] IDETestOperationsObserverDebug: (351B9941-B174-4A38-8A4C-50C60B770796) Finished requesting crash reports. Continuing with testing.

    [31m✗[0m testGETRequestCURLDescriptionSynchronous, Test crashed
-=-=-=-=-=-

-=-=-=-=-=-

[39;1mSelected tests[0m

Test Suite [39;1mAlamofire tvOS Tests.xctest[0m started

[39;1mRequestCURLDescriptionTestCase[0m

    [32;1m✓[0m testGETRequestWithCustomHeaderCURLDescription ([33m0.032[0m seconds)

    [32;1m✓[0m testGETRequestWithDuplicateHeadersDebugDescription (0.022 seconds)
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 8-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/566151224.log

[39;1mUploadStreamInitializationTestCase[0m

    [32;1m✓[0m testUploadClassMethodWithMethodURLAndStream ([33m0.052[0m seconds)

    [32;1m✓[0m testUploadClassMethodWithMethodURLHeadersAndStream ([33m0.048[0m seconds)





-=-=-=-=-=-

-=-=-=-=-=-
Alamofire_iOS_Tests.UploadMultipartFormDataTestCase

  testThatUploadingMultipartFormDataWhileStreamingFromDiskMonitorsProgress, [31mXCTAssertEqual failed: ("0.0") is not equal to ("1.0")[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/UploadTests.swift:645[0m

  qqq

[38;5;230m        [39m[38;5;221;01mif[39;00m[38;5;230m [39m[38;5;221;01mlet[39;00m[38;5;230m [39m[38;5;153;01mlastProgressValue[39;00m[38;5;230m [39m[38;5;87m=[39m[38;5;230m [39m[38;5;230mdownloadProgressValues[39m[38;5;87m.[39m[38;5;230mlast[39m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m            [39m[38;5;155;01mXCTAssertEqual[39;00m[38;5;87m([39m[38;5;230mlastProgressValue[39m[38;5;87m,[39m[38;5;230m [39m[38;5;212;01m1.0[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m        [39m[38;5;87m}[39m[38;5;230m [39m[38;5;221;01melse[39;00m[38;5;230m [39m[38;5;87m{[39m[38;5;230m

[38;5;230m[39m  qqq
-=-=-=-=-=-

-=-=-=-=-=-





[31m	 Executed 532 tests, with 1 failure (0 unexpected) in 34.172 (36.148) seconds

[0m

2019-07-31 20:12:36.125 xcodebuild[3103:7991]  IDETestOperationsObserverDebug: Failure collecting logarchive: Test daemon protocol version 22 is too old to support log archive collection (minimum 26)
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 9-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/566230265.log

[39;1mUploadStreamInitializationTestCase[0m

    [32;1m✓[0m testUploadClassMethodWithMethodURLAndStream ([33m0.043[0m seconds)

    [32;1m✓[0m testUploadClassMethodWithMethodURLHeadersAndStream ([33m0.043[0m seconds)





-=-=-=-=-=-

-=-=-=-=-=-
Alamofire_iOS_Tests.TLSEvaluationExpiredLeafCertificateTestCase

  testThatExpiredCertificateRequestSucceedsWhenPinningIntermediateCACertificateWithoutCertificateChainOrHostValidation, [31mAsynchronous wait failed: Exceeded timeout of 5 seconds, with unfulfilled expectations: "https://expired.badssl.com/".[0m

  [36m/Users/travis/build/Alamofire/Alamofire/Tests/TLSEvaluationTests.swift:384[0m

  qqq

[38;5;230m

[38;5;230m        [39m[38;5;153mwaitForExpectations[39m[38;5;87m([39m[38;5;153;01mtimeout[39;00m[38;5;87m:[39m[38;5;230m [39m[38;5;230mtimeout[39m[38;5;87m,[39m[38;5;230m [39m[38;5;153;01mhandler[39;00m[38;5;87m:[39m[38;5;230m [39m[38;5;212;01mnil[39;00m[38;5;87m)[39m[38;5;230m

[38;5;230m

[38;5;230m[39m  qqq
-=-=-=-=-=-

-=-=-=-=-=-





[31m	 Executed 532 tests, with 1 failure (0 unexpected) in 34.842 (35.987) seconds

[0m

2019-07-31 23:41:09.513 xcodebuild[3119:9925]  IDETestOperationsObserverDebug: Failure collecting logarchive: Test daemon protocol version 25 is too old to support log archive collection (minimum 26)
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 10-=-=-=-=-=--=-=-=-=-=-
Input path: Swift/Alamofire@Alamofire/failed/566793591.log




travis_time:start:0988a2ba
[0K$ if [ $RUN_TESTS == "YES" ]; then xcodebuild -workspace "$WORKSPACE" -scheme "$SCHEME" -destination "$DESTINATION" -configuration Release ONLY_ACTIVE_ARCH=NO ENABLE_TESTABILITY=YES test | xcpretty; else xcodebuild -workspace "$WORKSPACE" -scheme "$SCHEME" -destination "$DESTINATION" -configuration Release ONLY_ACTIVE_ARCH=NO build | xcpretty; fi

[33m▸[0m [39;1mProcessing[0m Info.plist



-=-=-=-=-=-

-=-=-=-=-=-
[31m❌  [0m/Users/travis/build/Alamofire/Alamofire/Source/ParameterEncoding.swift:269:57: [31mthrown expression type 'AFError.ParameterEncoderFailureReason' does not conform to 'Error'[0m



            throw AFError.ParameterEncoderFailureReason.missingRequiredComponent(.httpMethod(rawValue: "POST"))

[36m                  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~







[31m❌  [0m/Users/travis/build/Alamofire/Alamofire/Source/ParameterEncoding.swift:302:57: [31mthrown expression type 'AFError.ParameterEncoderFailureReason' does not conform to 'Error'[0m



            throw AFError.ParameterEncoderFailureReason.missingRequiredComponent(.httpMethod(rawValue: "POST"))

[36m                  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~[0m
-=-=-=-=-=-

-=-=-=-=-=-





** BUILD FAILED **
```

##### Category
→←

#### BuildFailureReason/Perl/sjdy521@Mojo-Webqq
##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 1-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/332708478.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.14/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 11 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 11 (wstat 2816, 0xb00)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 2-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/341246416.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.10/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 11 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 11 (wstat 2816, 0xb00)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 3-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/345524470.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.14/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 11 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 11 (wstat 2816, 0xb00)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 4-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/347585795.log

cp lib/Mojo/Webqq/User.pm blib/lib/Mojo/Webqq/User.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Plugin/StockInfo.pm blib/lib/Mojo/Webqq/Plugin/StockInfo.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/Translation.pm blib/lib/Mojo/Webqq/Plugin/Translation.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.20.3/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 11 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 11 (wstat 2816, 0xb00)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 5-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/367594701.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Run.pm blib/lib/Mojo/Webqq/Run.pm
cp lib/Mojo/Webqq/Server.pm blib/lib/Mojo/Webqq/Server.pm
cp lib/Mojo/Webqq/Plugin/Translation.pm blib/lib/Mojo/Webqq/Plugin/Translation.pm
cp lib/Mojo/Webqq/User.pm blib/lib/Mojo/Webqq/User.pm
cp lib/Mojo/Webqq/Recent/Group.pm blib/lib/Mojo/Webqq/Recent/Group.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.20.3/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 115 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 115 (wstat 29440, 0x7300)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 6-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/367594706.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.14/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 115 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 115 (wstat 29440, 0x7300)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 7-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/368688524.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.14/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 115 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 115 (wstat 29440, 0x7300)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 8-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/369927984.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.10/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 115 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 115 (wstat 29440, 0x7300)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 9-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/369957693.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.14/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 115 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 115 (wstat 29440, 0x7300)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←

##### BuildFailureReason & Context
```
-=-=-=-=-=--=-=-=-=-=-Example 10-=-=-=-=-=--=-=-=-=-=-
Input path: Perl/sjdy521@Mojo-Webqq/failed/373752512.log

cp lib/Mojo/Webqq/Plugin/SmartReply.pm blib/lib/Mojo/Webqq/Plugin/SmartReply.pm
cp lib/Mojo/Webqq/Recent/Friend.pm blib/lib/Mojo/Webqq/Recent/Friend.pm
cp lib/Mojo/Webqq/Plugin/UploadQRcode2.pm blib/lib/Mojo/Webqq/Plugin/UploadQRcode2.pm
cp lib/Mojo/Webqq/Plugin/ShowQRcode.pm blib/lib/Mojo/Webqq/Plugin/ShowQRcode.pm
cp lib/Mojo/Webqq/Plugin/ShowMsg.pm blib/lib/Mojo/Webqq/Plugin/ShowMsg.pm
cp lib/Mojo/Webqq/Recent/Discuss.pm blib/lib/Mojo/Webqq/Recent/Discuss.pm
cp lib/Mojo/Webqq/Request.pm blib/lib/Mojo/Webqq/Request.pm
cp lib/Mojo/Webqq/Util.pm blib/lib/Mojo/Webqq/Util.pm
cp lib/Mojo/Webqq/Plugin/ZiYue.pm blib/lib/Mojo/Webqq/Plugin/ZiYue.pm
PERL_DL_NONLAZY=1 "/home/travis/perl5/perlbrew/perls/5.14/bin/perl" "-MExtUtils::Command::MM" "-MTest::Harness" "-e" "undef *Test::Harness::Switches; test_harness(0, 'blib/lib', 'blib/arch')" t/*.t
-=-=-=-=-=-

-=-=-=-=-=-
t/https.t ........ Connection error: Connect timeout at t/https.t line 17.
# Looks like your test exited with 115 before it could output anything.
-=-=-=-=-=-

-=-=-=-=-=-
                        
t/https.t ........ Dubious, test returned 115 (wstat 29440, 0x7300)
Failed 1/1 subtests 
t/load_module.t .. 
t/load_module.t .. 1/1 
                        
t/load_module.t .. ok

Test Summary Report
-------------------
```

##### Category
→←



<!--## Leftover Repositories not used in validation
BuildFailureReason/C/php@php-src
BuildFailureReason/VimL/junegunn@vim-plug
BuildFailureReason/Lisp/emacs-tw@awesome-emacs
BuildFailureReason/PHP/composer@composer
BuildFailureReason/PHP/bcit-ci@CodeIgniter
BuildFailureReason/C/git@git
BuildFailureReason/Objective-C/Realm@realm-cocoa
BuildFailureReason/Shell/Tj@git-extras
BuildFailureReason/Scala/scala@scala
BuildFailureReason/Objective-C/ReactiveCocoa@ReactiveCocoa
BuildFailureReason/Perl/major@MySQLTuner-perl
BuildFailureReason/Erlang/rabbitmq@rabbitmq-server
BuildFailureReason/Rust/jwilm@alacritty
BuildFailureReason/Perl/jlord@git-it-electron
BuildFailureReason/HTML/necolas@normalize.css
BuildFailureReason/Haskell/koalaman@shellcheck
BuildFailureReason/Lisp/syl20bnr@spacemacs-->