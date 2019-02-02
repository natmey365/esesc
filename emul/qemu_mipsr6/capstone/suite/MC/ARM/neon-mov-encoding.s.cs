# CS_ARCH_ARM, CS_MODE_ARM, None
0x18,0x0e,0xc0,0xf2 = vmov.i8 d16, #0x8
0x10,0x08,0xc1,0xf2 = vmov.i16 d16, #0x10
0x10,0x0a,0xc1,0xf2 = vmov.i16 d16, #0x1000
0x10,0x00,0xc2,0xf2 = vmov.i32 d16, #0x20
0x10,0x02,0xc2,0xf2 = vmov.i32 d16, #0x2000
0x10,0x04,0xc2,0xf2 = vmov.i32 d16, #0x200000
0x10,0x06,0xc2,0xf2 = vmov.i32 d16, #0x20000000
0x10,0x0c,0xc2,0xf2 = vmov.i32 d16, #0x20ff
0x10,0x0d,0xc2,0xf2 = vmov.i32 d16, #0x20ffff
0x33,0x0e,0xc1,0xf3 = vmov.i64 d16, #0xff0000ff0000ffff
0x58,0x0e,0xc0,0xf2 = vmov.i8 q8, #0x8
0x50,0x08,0xc1,0xf2 = vmov.i16 q8, #0x10
0x50,0x0a,0xc1,0xf2 = vmov.i16 q8, #0x1000
0x50,0x00,0xc2,0xf2 = vmov.i32 q8, #0x20
0x50,0x02,0xc2,0xf2 = vmov.i32 q8, #0x2000
0x50,0x04,0xc2,0xf2 = vmov.i32 q8, #0x200000
0x50,0x06,0xc2,0xf2 = vmov.i32 q8, #0x20000000
0x50,0x0c,0xc2,0xf2 = vmov.i32 q8, #0x20ff
0x50,0x0d,0xc2,0xf2 = vmov.i32 q8, #0x20ffff
0x73,0x0e,0xc1,0xf3 = vmov.i64 q8, #0xff0000ff0000ffff
0x30,0x08,0xc1,0xf2 = vmvn.i16 d16, #0x10
0x30,0x0a,0xc1,0xf2 = vmvn.i16 d16, #0x1000
0x30,0x00,0xc2,0xf2 = vmvn.i32 d16, #0x20
0x30,0x02,0xc2,0xf2 = vmvn.i32 d16, #0x2000
0x30,0x04,0xc2,0xf2 = vmvn.i32 d16, #0x200000
0x30,0x06,0xc2,0xf2 = vmvn.i32 d16, #0x20000000
0x30,0x0c,0xc2,0xf2 = vmvn.i32 d16, #0x20ff
0x30,0x0d,0xc2,0xf2 = vmvn.i32 d16, #0x20ffff
0x30,0x0a,0xc8,0xf2 = vmovl.s8 q8, d16
0x30,0x0a,0xd0,0xf2 = vmovl.s16 q8, d16
0x30,0x0a,0xe0,0xf2 = vmovl.s32 q8, d16
0x30,0x0a,0xc8,0xf3 = vmovl.u8 q8, d16
0x30,0x0a,0xd0,0xf3 = vmovl.u16 q8, d16
0x30,0x0a,0xe0,0xf3 = vmovl.u32 q8, d16
0x20,0x02,0xf2,0xf3 = vmovn.i16 d16, q8
0x20,0x02,0xf6,0xf3 = vmovn.i32 d16, q8
0x20,0x02,0xfa,0xf3 = vmovn.i64 d16, q8
0xa0,0x02,0xf2,0xf3 = vqmovn.s16 d16, q8
0xa0,0x02,0xf6,0xf3 = vqmovn.s32 d16, q8
0xa0,0x02,0xfa,0xf3 = vqmovn.s64 d16, q8
0xe0,0x02,0xf2,0xf3 = vqmovn.u16 d16, q8
0xe0,0x02,0xf6,0xf3 = vqmovn.u32 d16, q8
0xe0,0x02,0xfa,0xf3 = vqmovn.u64 d16, q8
0x60,0x02,0xf2,0xf3 = vqmovun.s16 d16, q8
0x60,0x02,0xf6,0xf3 = vqmovun.s32 d16, q8
0x60,0x02,0xfa,0xf3 = vqmovun.s64 d16, q8
0xb0,0x0b,0x50,0xee = vmov.s8 r0, d16[1]
0xf0,0x0b,0x10,0xee = vmov.s16 r0, d16[1]
0xb0,0x0b,0xd0,0xee = vmov.u8 r0, d16[1]
0xf0,0x0b,0x90,0xee = vmov.u16 r0, d16[1]
0x90,0x0b,0x30,0xee = vmov.32 r0, d16[1]
0xb0,0x1b,0x40,0xee = vmov.8 d16[1], r1
0xf0,0x1b,0x00,0xee = vmov.16 d16[1], r1
0x90,0x1b,0x20,0xee = vmov.32 d16[1], r1
0xb0,0x1b,0x42,0xee = vmov.8 d18[1], r1
0xf0,0x1b,0x02,0xee = vmov.16 d18[1], r1
0x90,0x1b,0x22,0xee = vmov.32 d18[1], r1
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2
0x82,0x15,0xb0,0xf3 = vmvn d1, d2