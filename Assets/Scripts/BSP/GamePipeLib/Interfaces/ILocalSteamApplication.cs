/**
* Copyright (c) 2017 Joseph Shaw & Big Sky Software LLC
* Distributed under the GNU GPL v2. For full terms see the file LICENSE.txt
*/

namespace GamePipeLib.Interfaces
{
    public interface ILocalSteamApplication : ISteamApplication
    {
        string GameDir { get; }
    }
}
