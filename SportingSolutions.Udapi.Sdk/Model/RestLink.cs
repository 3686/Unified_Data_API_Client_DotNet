﻿//Copyright 2012 Spin Services Limited

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.


namespace SportingSolutions.Udapi.Sdk.Model
{
    public class RestLink
    {
        public string Relation { get; set; }
        public string Href { get; set; }
        public string[] Verbs { get; set; }

        public RestLink()
        {
        }

        public RestLink(string relation, string href, string[] verbs, bool sign = false)
        {
            Relation = relation;
            Href = href;
            Verbs = verbs;
        }
    }
}
