# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HDAONNHPGDA(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHDAONNHPGDA(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HDAONNHPGDA()
        x.Init(buf, n + offset)
        return x

    # HDAONNHPGDA
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HDAONNHPGDA
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # HDAONNHPGDA
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

def HDAONNHPGDAStart(builder): builder.StartObject(2)
def HDAONNHPGDAAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def HDAONNHPGDAAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(KJFEBMBHKOC), 0)
def HDAONNHPGDAEnd(builder): return builder.EndObject()
