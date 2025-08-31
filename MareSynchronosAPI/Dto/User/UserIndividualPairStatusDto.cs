using UnsungSync.API.Data;
using UnsungSync.API.Data.Enum;
using MessagePack;

namespace UnsungSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserIndividualPairStatusDto(UserData User, IndividualPairStatus IndividualPairStatus) : UserDto(User);