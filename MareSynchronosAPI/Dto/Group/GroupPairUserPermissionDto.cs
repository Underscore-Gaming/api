using UnsungSync.API.Data;
using UnsungSync.API.Data.Enum;
using MessagePack;

namespace UnsungSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);