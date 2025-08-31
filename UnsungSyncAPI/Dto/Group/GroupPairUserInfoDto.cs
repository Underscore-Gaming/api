using UnsungSync.API.Data;
using UnsungSync.API.Data.Enum;
using MessagePack;

namespace UnsungSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserInfoDto(GroupData Group, UserData User, GroupPairUserInfo GroupUserInfo) : GroupPairDto(Group, User);