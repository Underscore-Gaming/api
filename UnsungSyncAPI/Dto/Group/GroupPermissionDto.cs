using UnsungSync.API.Data;
using UnsungSync.API.Data.Enum;
using MessagePack;

namespace UnsungSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);