# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class OLDFIFPNMJO(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsOLDFIFPNMJO(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = OLDFIFPNMJO()
        x.Init(buf, n + offset)
        return x

    # OLDFIFPNMJO
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # OLDFIFPNMJO
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # OLDFIFPNMJO
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

def OLDFIFPNMJOStart(builder): builder.StartObject(2)
def OLDFIFPNMJOAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def OLDFIFPNMJOAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(KJFEBMBHKOC), 0)
def OLDFIFPNMJOEnd(builder): return builder.EndObject()
