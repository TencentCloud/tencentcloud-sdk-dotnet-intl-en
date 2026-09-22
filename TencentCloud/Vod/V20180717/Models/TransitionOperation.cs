/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransitionOperation : AbstractModel
    {
        
        /// <summary>
        /// Transition type. Valid values:
        /// <ul>
        /// <li>Image transition operation, used for transition processing between two video clip images:</li>
        /// <ul>
        /// <li>ImageFadeInFadeOut: image fade-in and fade-out. </li>
        /// <li>BowTieHorizontal: horizontal bow. </li>
        /// <li>BowTieVertical: vertical bow. </li>
        /// <li>ButterflyWaveScrawler: shake. </li>
        /// <li>Cannabisleaf: maple leaf. </li>
        /// <li>Circle: retract and release in an arc. </li>
        /// <li>CircleCrop: Ring gather. </li>
        /// <li>Circleopen: ellipse gather. </li>
        /// <li>Crosswarp: horizontal warping. </li>
        /// <li>Cube: cube. </li>
        /// <li>DoomScreenTransition: curtain. </li>
        /// <li>Doorway: Porch. </li>
        /// <li>Dreamy: wave. </li>
        /// <li>DreamyZoom: horizontal gathering. </li>
        /// <li>FilmBurn: Burning clouds. </li>
        /// <li>GlitchMemories: Jitter. </li>
        /// <li>Heart: heart shape. </li>
        /// <li>InvertedPageCurl: Page turning. </li>
        /// <li>Luma: Corrode. </li>
        /// <li>Mosaic: nine-grid. </li>
        /// <li>Pinwheel: windmill. </li>
        /// <li>PolarFunction: elliptic diffusion. </li>
        /// <li>PolkaDotsCurtain: Arc diffusion. </li>
        /// <li>Radial: radar scanning</li>
        /// <li>RotateScaleFade: up-down retraction. </li>
        /// <li>Squeeze: vertical gathering. </li>
        /// <li>Swap: enlarge and switch.</li>
        /// <li>Swirl: spiral. </li>
        /// <li>UndulatingBurnOutSwirl: Water flow spread. </li>
        /// <li>Windowblinds: window blind. </li>
        /// <li>WipeDown: collapse downward. </li>
        /// <li>WipeLeft: Collapse to the left. </li>
        /// <li>WipeRight: collapse rightward. </li>
        /// <li>WipeUp: collapse upward. </li>
        /// <li>ZoomInCircles: water ripple. </li>
        /// </ul>
        /// </li>
        /// <li>Audio transition operation, used for transition processing between two audio clips:
        /// <ul>
        /// <li>AudioFadeInFadeOut: sound fade-in and fade-out.</li>
        /// </ul>
        /// </li>
        /// </ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

