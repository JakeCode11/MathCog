﻿// /*******************************************************************************
//  * Analytical Geometry Semantic Parsing 
//  * <p>
//  * Copyright (C) 2014  Bo Kang, Hao Hu
//  * <p>
//  * This program is free software; you can redistribute it and/or modify it under
//  * the terms of the GNU General Public License as published by the Free Software
//  * Foundation; either version 2 of the License, or any later version.
//  * <p>
//  * This program is distributed in the hope that it will be useful, but WITHOUT
//  * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
//  * FOR A PARTICULAR PURPOSE. See the GNU General Public License for more
//  * details.
//  * <p>
//  * You should have received a copy of the GNU General Public License along with
//  * this program; if not, write to the Free Software Foundation, Inc., 51
//  * Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.
//  ******************************************************************************/

namespace ExprSemantic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AGKnowlegeReasoner
    {
        #region Singleton Pattern

        private AGKnowlegeReasoner()
        {

        }

        private static AGKnowlegeReasoner _agKnowlegeReasoner;

        public static AGKnowlegeReasoner Instance
        {
            get
            {
                if (_agKnowlegeReasoner == null)
                {
                    _agKnowlegeReasoner = new AGKnowlegeReasoner();
                }
                return _agKnowlegeReasoner;
            }
        }

        #endregion
/*
        public Shape MatchShape(string repr)
        {
            return null;
        }

        public void Query(Shape shape, string query)
        {
            
        }
*/
    }
}
