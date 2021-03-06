using System;
using System.Collections.Generic;
using System.Text;

namespace LibDotNetParser.CILApi.IL
{
    /// <summary>
    /// List of CIL Opcodes
    /// </summary>
    public static class OpCodes
    {
        //This File was generated by a tool that MishaProductions made.

        // List of CIL Opcodes
        // Single opcodes
        public static readonly OpCode[] SingleOpCodes = new OpCode[256]
        {
new OpCode("nop", 0, OpCodeOperandType.InlineNone),
new OpCode("break", 1, OpCodeOperandType.InlineNone),
new OpCode("ldarg.0", 2, OpCodeOperandType.InlineNone),
new OpCode("ldarg.1", 3, OpCodeOperandType.InlineNone),
new OpCode("ldarg.2", 4, OpCodeOperandType.InlineNone),
new OpCode("ldarg.3", 5, OpCodeOperandType.InlineNone),
new OpCode("ldloc.0", 6, OpCodeOperandType.InlineNone),
new OpCode("ldloc.1", 7, OpCodeOperandType.InlineNone),
new OpCode("ldloc.2", 8, OpCodeOperandType.InlineNone),
new OpCode("ldloc.3", 9, OpCodeOperandType.InlineNone),
new OpCode("stloc.0", 10, OpCodeOperandType.InlineNone),
new OpCode("stloc.1", 11, OpCodeOperandType.InlineNone),
new OpCode("stloc.2", 12, OpCodeOperandType.InlineNone),
new OpCode("stloc.3", 13, OpCodeOperandType.InlineNone),
new OpCode("ldarg.s", 14, OpCodeOperandType.ShortInlineVar),
new OpCode("ldarga.s", 15, OpCodeOperandType.ShortInlineVar),
new OpCode("starg.s", 16, OpCodeOperandType.ShortInlineVar),
new OpCode("ldloc.s", 17, OpCodeOperandType.ShortInlineVar),
new OpCode("ldloca.s", 18, OpCodeOperandType.ShortInlineVar),
new OpCode("stloc.s", 19, OpCodeOperandType.ShortInlineVar),
new OpCode("ldnull", 20, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.m1", 21, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.0", 22, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.1", 23, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.2", 24, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.3", 25, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.4", 26, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.5", 27, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.6", 28, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.7", 29, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.8", 30, OpCodeOperandType.InlineNone),
new OpCode("ldc.i4.s", 31, OpCodeOperandType.ShortInlineI),
new OpCode("ldc.i4", 32, OpCodeOperandType.InlineI),
new OpCode("ldc.i8", 33, OpCodeOperandType.InlineI8),
new OpCode("ldc.r4", 34, OpCodeOperandType.ShortInlineR),
new OpCode("ldc.r8", 35, OpCodeOperandType.InlineR),
null,
new OpCode("dup", 37, OpCodeOperandType.InlineNone),
new OpCode("pop", 38, OpCodeOperandType.InlineNone),
new OpCode("jmp", 39, OpCodeOperandType.InlineMethod),
new OpCode("call", 40, OpCodeOperandType.InlineMethod),
new OpCode("calli", 41, OpCodeOperandType.InlineSig),
new OpCode("ret", 42, OpCodeOperandType.InlineNone),
new OpCode("br.s", 43, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("brfalse.s", 44, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("brtrue.s", 45, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("beq.s", 46, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("bge.s", 47, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("bgt.s", 48, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("ble.s", 49, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("blt.s", 50, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("bne.un.s", 51, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("bge.un.s", 52, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("bgt.un.s", 53, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("ble.un.s", 54, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("blt.un.s", 55, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("br", 56, OpCodeOperandType.InlineBrTarget),
new OpCode("brfalse", 57, OpCodeOperandType.InlineBrTarget),
new OpCode("brtrue", 58, OpCodeOperandType.InlineBrTarget),
new OpCode("beq", 59, OpCodeOperandType.InlineBrTarget),
new OpCode("bge", 60, OpCodeOperandType.InlineBrTarget),
new OpCode("bgt", 61, OpCodeOperandType.InlineBrTarget),
new OpCode("ble", 62, OpCodeOperandType.InlineBrTarget),
new OpCode("blt", 63, OpCodeOperandType.InlineBrTarget),
new OpCode("bne.un", 64, OpCodeOperandType.InlineBrTarget),
new OpCode("bge.un", 65, OpCodeOperandType.InlineBrTarget),
new OpCode("bgt.un", 66, OpCodeOperandType.InlineBrTarget),
new OpCode("ble.un", 67, OpCodeOperandType.InlineBrTarget),
new OpCode("blt.un", 68, OpCodeOperandType.InlineBrTarget),
new OpCode("switch", 69, OpCodeOperandType.InlineSwitch),
new OpCode("ldind.i1", 70, OpCodeOperandType.InlineNone),
new OpCode("ldind.u1", 71, OpCodeOperandType.InlineNone),
new OpCode("ldind.i2", 72, OpCodeOperandType.InlineNone),
new OpCode("ldind.u2", 73, OpCodeOperandType.InlineNone),
new OpCode("ldind.i4", 74, OpCodeOperandType.InlineNone),
new OpCode("ldind.u4", 75, OpCodeOperandType.InlineNone),
new OpCode("ldind.i8", 76, OpCodeOperandType.InlineNone),
new OpCode("ldind.i", 77, OpCodeOperandType.InlineNone),
new OpCode("ldind.r4", 78, OpCodeOperandType.InlineNone),
new OpCode("ldind.r8", 79, OpCodeOperandType.InlineNone),
new OpCode("ldind.ref", 80, OpCodeOperandType.InlineNone),
new OpCode("stind.ref", 81, OpCodeOperandType.InlineNone),
new OpCode("stind.i1", 82, OpCodeOperandType.InlineNone),
new OpCode("stind.i2", 83, OpCodeOperandType.InlineNone),
new OpCode("stind.i4", 84, OpCodeOperandType.InlineNone),
new OpCode("stind.i8", 85, OpCodeOperandType.InlineNone),
new OpCode("stind.r4", 86, OpCodeOperandType.InlineNone),
new OpCode("stind.r8", 87, OpCodeOperandType.InlineNone),
new OpCode("add", 88, OpCodeOperandType.InlineNone),
new OpCode("sub", 89, OpCodeOperandType.InlineNone),
new OpCode("mul", 90, OpCodeOperandType.InlineNone),
new OpCode("div", 91, OpCodeOperandType.InlineNone),
new OpCode("div.un", 92, OpCodeOperandType.InlineNone),
new OpCode("rem", 93, OpCodeOperandType.InlineNone),
new OpCode("rem.un", 94, OpCodeOperandType.InlineNone),
new OpCode("and", 95, OpCodeOperandType.InlineNone),
new OpCode("or", 96, OpCodeOperandType.InlineNone),
new OpCode("xor", 97, OpCodeOperandType.InlineNone),
new OpCode("shl", 98, OpCodeOperandType.InlineNone),
new OpCode("shr", 99, OpCodeOperandType.InlineNone),
new OpCode("shr.un", 100, OpCodeOperandType.InlineNone),
new OpCode("neg", 101, OpCodeOperandType.InlineNone),
new OpCode("not", 102, OpCodeOperandType.InlineNone),
new OpCode("conv.i1", 103, OpCodeOperandType.InlineNone),
new OpCode("conv.i2", 104, OpCodeOperandType.InlineNone),
new OpCode("conv.i4", 105, OpCodeOperandType.InlineNone),
new OpCode("conv.i8", 106, OpCodeOperandType.InlineNone),
new OpCode("conv.r4", 107, OpCodeOperandType.InlineNone),
new OpCode("conv.r8", 108, OpCodeOperandType.InlineNone),
new OpCode("conv.u4", 109, OpCodeOperandType.InlineNone),
new OpCode("conv.u8", 110, OpCodeOperandType.InlineNone),
new OpCode("callvirt", 111, OpCodeOperandType.InlineMethod),
new OpCode("cpobj", 112, OpCodeOperandType.InlineType),
new OpCode("ldobj", 113, OpCodeOperandType.InlineType),
new OpCode("ldstr", 114, OpCodeOperandType.InlineString),
new OpCode("newobj", 115, OpCodeOperandType.InlineMethod),
new OpCode("castclass", 116, OpCodeOperandType.InlineType),
new OpCode("isinst", 117, OpCodeOperandType.InlineType),
new OpCode("conv.r.un", 118, OpCodeOperandType.InlineNone),
null,
null,
new OpCode("unbox", 121, OpCodeOperandType.InlineType),
new OpCode("throw", 122, OpCodeOperandType.InlineNone),
new OpCode("ldfld", 123, OpCodeOperandType.InlineField),
new OpCode("ldflda", 124, OpCodeOperandType.InlineField),
new OpCode("stfld", 125, OpCodeOperandType.InlineField),
new OpCode("ldsfld", 126, OpCodeOperandType.InlineField),
new OpCode("ldsflda", 127, OpCodeOperandType.InlineField),
new OpCode("stsfld", 128, OpCodeOperandType.InlineField),
new OpCode("stobj", 129, OpCodeOperandType.InlineType),
new OpCode("conv.ovf.i1.un", 130, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i2.un", 131, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i4.un", 132, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i8.un", 133, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u1.un", 134, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u2.un", 135, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u4.un", 136, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u8.un", 137, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i.un", 138, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u.un", 139, OpCodeOperandType.InlineNone),
new OpCode("box", 140, OpCodeOperandType.InlineType),
new OpCode("newarr", 141, OpCodeOperandType.InlineType),
new OpCode("ldlen", 142, OpCodeOperandType.InlineNone),
new OpCode("ldelema", 143, OpCodeOperandType.InlineType),
new OpCode("ldelem.i1", 144, OpCodeOperandType.InlineNone),
new OpCode("ldelem.u1", 145, OpCodeOperandType.InlineNone),
new OpCode("ldelem.i2", 146, OpCodeOperandType.InlineNone),
new OpCode("ldelem.u2", 147, OpCodeOperandType.InlineNone),
new OpCode("ldelem.i4", 148, OpCodeOperandType.InlineNone),
new OpCode("ldelem.u4", 149, OpCodeOperandType.InlineNone),
new OpCode("ldelem.i8", 150, OpCodeOperandType.InlineNone),
new OpCode("ldelem.i", 151, OpCodeOperandType.InlineNone),
new OpCode("ldelem.r4", 152, OpCodeOperandType.InlineNone),
new OpCode("ldelem.r8", 153, OpCodeOperandType.InlineNone),
new OpCode("ldelem.ref", 154, OpCodeOperandType.InlineNone),
new OpCode("stelem.i", 155, OpCodeOperandType.InlineNone),
new OpCode("stelem.i1", 156, OpCodeOperandType.InlineNone),
new OpCode("stelem.i2", 157, OpCodeOperandType.InlineNone),
new OpCode("stelem.i4", 158, OpCodeOperandType.InlineNone),
new OpCode("stelem.i8", 159, OpCodeOperandType.InlineNone),
new OpCode("stelem.r4", 160, OpCodeOperandType.InlineNone),
new OpCode("stelem.r8", 161, OpCodeOperandType.InlineNone),
new OpCode("stelem.ref", 162, OpCodeOperandType.InlineNone),
new OpCode("ldelem", 163, OpCodeOperandType.InlineType),
new OpCode("stelem", 164, OpCodeOperandType.InlineType),
new OpCode("unbox.any", 165, OpCodeOperandType.InlineType),
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
new OpCode("conv.ovf.i1", 179, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u1", 180, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i2", 181, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u2", 182, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i4", 183, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u4", 184, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i8", 185, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u8", 186, OpCodeOperandType.InlineNone),
null,
null,
null,
null,
null,
null,
null,
new OpCode("refanyval", 194, OpCodeOperandType.InlineType),
new OpCode("ckfinite", 195, OpCodeOperandType.InlineNone),
null,
null,
new OpCode("mkrefany", 198, OpCodeOperandType.InlineType),
null,
null,
null,
null,
null,
null,
null,
null,
null,
new OpCode("ldtoken", 208, OpCodeOperandType.InlineTok),
new OpCode("conv.u2", 209, OpCodeOperandType.InlineNone),
new OpCode("conv.u1", 210, OpCodeOperandType.InlineNone),
new OpCode("conv.i", 211, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.i", 212, OpCodeOperandType.InlineNone),
new OpCode("conv.ovf.u", 213, OpCodeOperandType.InlineNone),
new OpCode("add.ovf", 214, OpCodeOperandType.InlineNone),
new OpCode("add.ovf.un", 215, OpCodeOperandType.InlineNone),
new OpCode("mul.ovf", 216, OpCodeOperandType.InlineNone),
new OpCode("mul.ovf.un", 217, OpCodeOperandType.InlineNone),
new OpCode("sub.ovf", 218, OpCodeOperandType.InlineNone),
new OpCode("sub.ovf.un", 219, OpCodeOperandType.InlineNone),
new OpCode("endfinally", 220, OpCodeOperandType.InlineNone),
new OpCode("leave", 221, OpCodeOperandType.InlineBrTarget),
new OpCode("leave.s", 222, OpCodeOperandType.ShortInlineBrTarget),
new OpCode("stind.i", 223, OpCodeOperandType.InlineNone),
new OpCode("conv.u", 224, OpCodeOperandType.InlineNone),
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
new OpCode("prefix7", 248, OpCodeOperandType.InlineNone),
new OpCode("prefix6", 249, OpCodeOperandType.InlineNone),
new OpCode("prefix5", 250, OpCodeOperandType.InlineNone),
new OpCode("prefix4", 251, OpCodeOperandType.InlineNone),
new OpCode("prefix3", 252, OpCodeOperandType.InlineNone),
new OpCode("prefix2", 253, OpCodeOperandType.InlineNone),
new OpCode("prefix1", 254, OpCodeOperandType.InlineNone),
new OpCode("prefixref", 255, OpCodeOperandType.InlineNone),
        };


        // Multi opcodes

        public static readonly OpCode[] MultiOpCodes = new OpCode[256]
        {
new OpCode("arglist", 0, OpCodeOperandType.InlineNone, true),
new OpCode("ceq", 1, OpCodeOperandType.InlineNone, true),
new OpCode("cgt", 2, OpCodeOperandType.InlineNone, true),
new OpCode("cgt.un", 3, OpCodeOperandType.InlineNone, true),
new OpCode("clt", 4, OpCodeOperandType.InlineNone, true),
new OpCode("clt.un", 5, OpCodeOperandType.InlineNone, true),
new OpCode("ldftn", 6, OpCodeOperandType.InlineMethod, true),
new OpCode("ldvirtftn", 7, OpCodeOperandType.InlineMethod, true),
null,
new OpCode("ldarg", 9, OpCodeOperandType.InlineVar, true),
new OpCode("ldarga", 10, OpCodeOperandType.InlineVar, true),
new OpCode("starg", 11, OpCodeOperandType.InlineVar, true),
new OpCode("ldloc", 12, OpCodeOperandType.InlineVar, true),
new OpCode("ldloca", 13, OpCodeOperandType.InlineVar, true),
new OpCode("stloc", 14, OpCodeOperandType.InlineVar, true),
new OpCode("localloc", 15, OpCodeOperandType.InlineNone, true),
null,
new OpCode("endfilter", 17, OpCodeOperandType.InlineNone, true),
new OpCode("unaligned.", 18, OpCodeOperandType.ShortInlineI, true),
new OpCode("volatile.", 19, OpCodeOperandType.InlineNone, true),
new OpCode("tail.", 20, OpCodeOperandType.InlineNone, true),
new OpCode("initobj", 21, OpCodeOperandType.InlineType, true),
new OpCode("constrained.", 22, OpCodeOperandType.InlineType, true),
new OpCode("cpblk", 23, OpCodeOperandType.InlineNone, true),
new OpCode("initblk", 24, OpCodeOperandType.InlineNone, true),
null,
new OpCode("rethrow", 26, OpCodeOperandType.InlineNone, true),
null,
new OpCode("sizeof", 28, OpCodeOperandType.InlineType, true),
new OpCode("refanytype", 29, OpCodeOperandType.InlineNone, true),
new OpCode("readonly.", 30, OpCodeOperandType.InlineNone, true),
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
null,
        };
    }
}
