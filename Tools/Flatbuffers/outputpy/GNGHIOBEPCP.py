# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class GNGHIOBEPCP(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsGNGHIOBEPCP(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = GNGHIOBEPCP()
        x.Init(buf, n + offset)
        return x

    # GNGHIOBEPCP
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # GNGHIOBEPCP
    def FGONCIDNPDP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # GNGHIOBEPCP
    def DLPCOLDNAKE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def GNGHIOBEPCPStart(builder): builder.StartObject(2)
def GNGHIOBEPCPAddFGONCIDNPDP(builder, FGONCIDNPDP): builder.PrependInt32Slot(0, FGONCIDNPDP, 0)
def GNGHIOBEPCPAddDLPCOLDNAKE(builder, DLPCOLDNAKE): builder.PrependInt32Slot(1, DLPCOLDNAKE, 0)
def GNGHIOBEPCPEnd(builder): return builder.EndObject()
