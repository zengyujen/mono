// cs3005-3.cs: Identifier `CLSClass.value' differing only in case is not CLS-compliant
// Compiler options: -warnaserror
// Line: 15

[assembly:System.CLSCompliant(true)]

public class X {
        public bool Value;
}

public class Y: X {
        private readonly bool vAalue;
}
    
public class CLSClass: Y {
        protected internal bool value;
}
