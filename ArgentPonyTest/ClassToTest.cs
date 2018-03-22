using ArgentPonyWarcraftClient;
using System;
using System.Threading.Tasks;

namespace ArgentPonyTest
{
    public class ClassToTest
    {
        private readonly WarcraftClient _client;

        public ClassToTest(WarcraftClient client)
        {
            _client = client;
        }

        public async Task<string> GetGuildNameForCharacter(string character, string realm)
        {
            var characterInfo = await _client.GetCharacterAsync(realm, character, CharacterFields.Guild);

            if (characterInfo.Success)
            {
                return characterInfo.Value.Guild.Name;
            }

            throw new Exception(characterInfo.Error.Detail);
        }
    }
}
