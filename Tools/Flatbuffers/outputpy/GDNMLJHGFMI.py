# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class GDNMLJHGFMI(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsGDNMLJHGFMI(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = GDNMLJHGFMI()
        x.Init(buf, n + offset)
        return x

    # GDNMLJHGFMI
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # GDNMLJHGFMI
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # GDNMLJHGFMI
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def GDNMLJHGFMIStart(builder): builder.StartObject(2)
def GDNMLJHGFMIAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def GDNMLJHGFMIAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependUint32Slot(1, KJFEBMBHKOC, 0)
def GDNMLJHGFMIEnd(builder): return builder.EndObject()
