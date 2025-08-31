using UnsungSync.API.Data;
using MessagePack;

namespace UnsungSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);