// cs3005-13.cs: Identifier `CLSEnum.Label' differing only in case is not CLS-compliant
// Compiler options: -warnaserror
// Line: 9

//
// NOTE: This is only an error in MCS - in GMCS, it's just a warning.
//

using System;
[assembly:CLSCompliant (true)]

public enum CLSEnum {
        label,
        Label
}
