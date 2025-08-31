using UnsungSync.API.Data;
using UnsungSync.API.Data.Enum;
using MessagePack;

namespace UnsungSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
