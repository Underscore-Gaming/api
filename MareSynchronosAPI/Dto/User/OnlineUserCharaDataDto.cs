using UnsungSync.API.Data;
using MessagePack;

namespace UnsungSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserCharaDataDto(UserData User, CharacterData CharaData) : UserDto(User);